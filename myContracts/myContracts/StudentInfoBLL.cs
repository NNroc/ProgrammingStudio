using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace myContracts
{
    class StudentInfoBLL
    {
        //XML document path
        private static string _basePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/Students.xml";
        
        ///<summary>
        /// Creaete student's XML document
        /// </summary>
        
        public static void CreateStudentXml()
        {
            XDocument studentDoc = new XDocument();
            XDeclaration xDeclaration = new XDeclaration("1.0", "utf-8", "yes");
            studentDoc.Declaration = xDeclaration;
            XElement xElement = new XElement("studentcontract");
            studentDoc.Add(xElement);
            studentDoc.Save(_basePath);
        }

        ///<summary>
        /// Add student's imformation
        /// </summary>
        
        public static bool AddStudentInfo (StudentInfo param)
        {
            XElement xml = XElement.Load(_basePath);
            List<StudentInfo> students = (from student in xml.Descendants("student")
                where student.Attribute("studentid").Value == param.StudentId.ToString()
                select new StudentInfo
                {
                    StudentId = Int32.Parse(student.Attribute("studentid").Value),
                    Name = student.Element("name").Value,
                    Age = Int32.Parse(student.Element("age").Value),
                    Sex = student.Element("sex").Value,
                    BirthDate = DateTime.Parse(student.Element("birthdate").Value),
                    Phone = student.Element("phone").Value,
                    HomeAddress = student.Element("homeaddress").Value,
                    Email = student.Element("email").Value,
                    Profession = student.Element("profession").Value
                }).ToList();

            if (students.Count == 0)
            {
                XElement studentXml = new XElement("student");
                studentXml.Add(new XAttribute("studentid", param.StudentId));
                studentXml.Add(new XElement("name", param.Name));
                studentXml.Add(new XElement("sex", param.Sex));
                studentXml.Add(new XElement("age", param.Age.ToString()));
                studentXml.Add(new XElement("birthdate", param.BirthDate.ToString("yyyy-MM-dd")));
                studentXml.Add(new XElement("phone", param.Phone));
                studentXml.Add(new XElement("homeaddress", param.HomeAddress));
                studentXml.Add(new XElement("email", param.Email));
                studentXml.Add(new XElement("profession", param.Profession));
                xml.Add(studentXml);
                xml.Save(_basePath);
            }
            else
            {
                return false;
            }
            return true;
        }

        ///<summary>
        /// Add student's imformation
        /// </summary>

        public static bool UpdateStudentInfo (StudentInfo param)
        {
            bool result = false;
            if (param.StudentId > 0)
            {
                XElement xml = XElement.Load(_basePath);
                XElement studentXml = (from db in xml.Descendants("student")
                                       where db.Attribute("studentid").Value == param.StudentId.ToString()
                                       select db).Single();

                studentXml.SetElementValue("name", param.Name);
                studentXml.SetElementValue("sex", param.Sex);
                studentXml.SetElementValue("age", param.Age.ToString());
                studentXml.SetElementValue("birthdate", param.BirthDate.ToString("yyyy-MM-dd"));
                studentXml.SetElementValue("phone", param.Phone);
                studentXml.SetElementValue("homeaddress", param.HomeAddress);
                studentXml.SetElementValue("email", param.Email);
                studentXml.SetElementValue("profession", param.Profession);

                xml.Save(_basePath);
                result = true;
            }

            return result;
        }

        /// <summary>
        /// delete student's information
        /// </summary>

        public static bool DeleteStudentInfo(int studentid)
        {
            bool result = false;
            if (studentid>0)
            {
                XElement xml = XElement.Load(_basePath);
                XElement studentXml = (from db in xml.Descendants("student")
                                       where db.Attribute("studentid").Value == studentid.ToString()
                                       select db).Single();
                studentXml.Remove();
                xml.Save(_basePath);
                result = true;
            }
            return result;
        }

        /// <summary>
        /// Search student's information
        /// </summary>

        public static List<StudentInfo> GetAllStudentInfo()
        {
            List<StudentInfo> studentList = new List<StudentInfo>();
            XElement xml = XElement.Load(_basePath);

            var studentVar = xml.Descendants("student");

            studentList = (from student in studentVar
                           select new StudentInfo
                           {
                               StudentId = Int32.Parse(student.Attribute("studentid").Value),
                               Name = student.Element("name").Value,
                               Age = Int32.Parse(student.Element("age").Value),
                               Sex = student.Element("sex").Value,
                               BirthDate = DateTime.Parse(student.Element("birthdate").Value),
                               Phone = student.Element("phone").Value,
                               HomeAddress = student.Element("homeaddress").Value,
                               Email = student.Element("email").Value,
                               Profession = student.Element("profession").Value
                           }).ToList();

            return studentList;
        }

        /// <summary>
        /// Search student's informantion by Id
        /// </summary>

        public static StudentInfo GetStudentInfo(int studentid)
        {
            StudentInfo studentinfo = new StudentInfo();
            XElement xml = XElement.Load(_basePath);
            studentinfo = (from student in xml.Descendants("student")
                           where student.Attribute("studentid").Value == studentid.ToString()
                           select new StudentInfo
                           {
                               StudentId = Int32.Parse(student.Attribute("studentid").Value),
                               Name = student.Element("name").Value,
                               Age = Int32.Parse(student.Element("age").Value),
                               Sex = student.Element("sex").Value,
                               BirthDate = DateTime.Parse(student.Element("birthdate").Value),
                               Phone = student.Element("phone").Value,
                               HomeAddress = student.Element("homeaddress").Value,
                               Email = student.Element("email").Value,
                               Profession = student.Element("profession").Value
                           }).Single();
            return studentinfo;
        }

        /// <summary>
        /// Get list (Search)
        /// </summary>

        public static List<StudentInfo>GetStudentInfoList (StudentInfo param)
        {
            List<StudentInfo> studentList = new List<StudentInfo> ();
            XElement xml = XElement.Load(_basePath);

            Regex r = new Regex(".*"+ param.Name +".*");
            var studentVar = xml.Descendants("student");
            if (param.StudentId != 0)
            {
                studentVar = xml.Descendants("student").Where(a => a.Attribute("studentid").Value == param.StudentId.ToString());
            }
            else if (!String.IsNullOrEmpty(param.Name))
            {
                /// studentVar = xml.Descendants("student").Where(a => a.Element("name").Value == param.Name);
                studentVar = xml.Descendants("student").Where(a => r.IsMatch(a.Element("name").Value));
            }

            studentList = (from student in studentVar
                           select new StudentInfo
                           {
                               StudentId = Int32.Parse(student.Attribute("studentid").Value),
                               Name = student.Element("name").Value,
                               Age = Int32.Parse(student.Element("age").Value),
                               Sex = student.Element("sex").Value,
                               BirthDate = DateTime.Parse(student.Element("birthdate").Value),
                               Phone = student.Element("phone").Value,
                               HomeAddress = student.Element("homeaddress").Value,
                               Email = student.Element("email").Value,
                               Profession = student.Element("profession").Value
                           }).ToList();
            return studentList;
        }

        /// <summary>
        /// Save List
        /// </summary>

        public void SaveStudentInfoList()
        {
            XElement xml = XElement.Load(_basePath);
            string filename;
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "XML文件(*.xml)|*.xml";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filename = dialog.FileName;
                    xml.Save(filename);
                    MessageBox.Show("备份成功", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch
                {
                    MessageBox.Show("备份失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Recover List
        /// </summary>

        public void RecoverStudentInfo()
        {
            XElement xml;
            string filename;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "XML文件(*.xml)|*.xml";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filename = dialog.FileName;
                    xml = XElement.Load(filename);
                    xml.Save(_basePath);
                    MessageBox.Show("恢复成功", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch
                {
                    MessageBox.Show("恢复失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Get profession List
        /// </summary>

        public TreeNode GetProfessionNode()
        {
            List<string> professionlist = new List<string>();
            XElement xml = XElement.Load(_basePath);

            var studentVar = xml.Descendants("profession");

            professionlist = (from profession in studentVar
                              select new string(profession.Value.ToCharArray())).ToList();

            professionlist.Sort();
            TreeNode professiontree = new TreeNode();
            TreeNode newnode = new TreeNode();
            professiontree.Name = "profession";
            professiontree.Text = "专业";
            newnode.Name = professionlist.First();
            newnode.Text = newnode.Name;
            professiontree.Nodes.Add(newnode);
            professionlist.Remove(professionlist.First());

            while (professionlist.Count != 0)
            {
                if (newnode.Name != professionlist.First())
                {
                    newnode = new TreeNode();
                    newnode.Name = professionlist.First();
                    newnode.Text = newnode.Name;
                    professiontree.Nodes.Add(newnode);
                }
                professionlist.RemoveAt(0);
            }

            return professiontree;
        }

        public static List<StudentInfo> GetStudentInfoListByProfession(string pname)
        {
            List<StudentInfo> studentinfos = new List<StudentInfo>();
            XElement xml = XElement.Load(_basePath);
            studentinfos = (from student in xml.Descendants("student")
                           where student.Element("profession").Value == pname
                           select new StudentInfo
                           {
                               StudentId = Int32.Parse(student.Attribute("studentid").Value),
                               Name = student.Element("name").Value,
                               Age = Int32.Parse(student.Element("age").Value),
                               Sex = student.Element("sex").Value,
                               BirthDate = DateTime.Parse(student.Element("birthdate").Value),
                               Phone = student.Element("phone").Value,
                               HomeAddress = student.Element("homeaddress").Value,
                               Email = student.Element("email").Value,
                               Profession = student.Element("profession").Value
                           }).ToList();
            return studentinfos;
        }
    }
}
