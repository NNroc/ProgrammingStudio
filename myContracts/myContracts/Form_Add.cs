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
    public partial class Form_Add : Form
    {
        public Form_Add()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            if (txt_studengid.Text == ""||
            txt_age.Text == ""||
            txt_email.Text == ""||
            txt_homeaddress.Text == ""||
            txt_name.Text == ""||
            txt_phone.Text == ""||
            txt_profession.Text == ""||
            (rb_man.Checked == false &&
            rb_woman.Checked == false))
            {
                MessageBox.Show("添加学生信息失败,请检查信息是否填写完整。");
                return;
            }
            StudentInfo studentinfo = new StudentInfo();
            
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

            if (StudentInfoBLL.AddStudentInfo(studentinfo))
            {
                MessageBox.Show("添加学生信息成功！");
                txt_studengid.Text = "";
                txt_age.Text = "";
                txt_email.Text = "";
                txt_homeaddress.Text = "";
                txt_name.Text = "";
                txt_phone.Text = "";
                txt_profession.Text = "";
                dt_birthday.Value = DateTime.Now;
                rb_man.Checked = false;
                rb_woman.Checked = false;
            }
            else
            {
                MessageBox.Show("添加学生信息失败,学生编号重复。");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dt_birthday_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Now<DateTime.Parse(dt_birthday.Text))
            {
                MessageBox.Show("你这是还没出生？");
                dt_birthday.Text = DateTime.Now.ToString();
                return;
            }
            txt_age.Text = (DateTime.Now.Year - DateTime.Parse(dt_birthday.Text).Year).ToString();
        }
    }
}
