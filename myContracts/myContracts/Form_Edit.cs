using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myContracts
{
    public partial class Form_Edit : Form
    {
        public Form_Edit()
        {
            InitializeComponent();
        }

        public int studentid_edit = 0;
        public void initControl()
        {
            StudentInfo studentinfo = StudentInfoBLL.GetStudentInfo(studentid_edit);
            if (studentinfo != null)
            {
                txt_studengid.Text = studentinfo.StudentId.ToString();
                txt_name.Text = studentinfo.Name;
                if (studentinfo.Sex == "男")
                {
                    rb_man.Checked = true;
                    rb_woman.Checked = false;
                }
                txt_age.Text = studentinfo.Age.ToString();
                dt_birthday.Text = studentinfo.BirthDate.ToString();
                txt_phone.Text = studentinfo.Phone;
                txt_email.Text = studentinfo.Email;
                txt_homeaddress.Text = studentinfo.HomeAddress;
                txt_profession.Text = studentinfo.Profession;
            }
        }

        private void Form_Edit_Load(object sender, EventArgs e)
        {
            initControl();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            StudentInfo studentinfo = StudentInfoBLL.GetStudentInfo(studentid_edit);
            
            Regex r = new Regex("^([a-zA-Z]|[0-9])(\\w|\\-)+@[a-zA-Z0-9]+\\.([a-zA-Z]{2,4})$");
            if (!r.IsMatch(txt_email.Text.ToString()))
            {
                MessageBox.Show(txt_email.Text.ToString() + " 不是个正确的邮箱");
                return;
            }
            
            Regex id = new Regex("^\\+?[1-9][0-9]*$");
            if (!id.IsMatch(txt_studengid.Text))
            {
                MessageBox.Show("编号"+ txt_studengid.Text +"不是个正整数");
                return;
            }
            
            studentinfo.StudentId = Int32.Parse(txt_studengid.Text);
            studentinfo.Name = txt_name.Text;
            if (rb_man.Checked)
                studentinfo.Sex = "男";
            else if (rb_woman.Checked)
                studentinfo.Sex = "女";
            studentinfo.Age = Int32.Parse(txt_age.Text);
            studentinfo.BirthDate = DateTime.Parse(dt_birthday.Text);
            studentinfo.Phone = txt_phone.Text;
            studentinfo.Email = txt_email.Text;
            studentinfo.HomeAddress = txt_homeaddress.Text;
            studentinfo.Profession = txt_profession.Text;

            if (StudentInfoBLL.UpdateStudentInfo(studentinfo))
            {
                MessageBox.Show("修改学生信息成功！");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dt_birthday_ValueChanged(object sender, EventArgs e)
        {
            txt_age.Text = (DateTime.Now.Year - DateTime.Parse(dt_birthday.Text).Year).ToString();
        }
    }
}
