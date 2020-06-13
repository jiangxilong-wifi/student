using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Gender
{
    public partial class xiugai : Form
    {
        public xiugai()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //判断性别修改
            if(radioButton_boy.Checked)
            {
                gender = radioButton_boy.Text;
            }
            else
            {
                gender = radioButton_gril.Text;
            }
            string sql = string.Format("update student_stu set stuName='{0}',stuGender='{1}',stuBirthday='{2}',stuClass='{3}',stuPhoto='{4}' where stuid={5}",textBox_student_name.Text,gender,textBox_birthday.Text,comboBox1.Text,textBox_photo.Text,center.row);
            if (DBHelper.ExecuteNonQuery(sql))
            {
                DialogResult result= MessageBox.Show("修改成功！是否回到原界面", "提示", MessageBoxButtons.OKCancel);
                if(result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
        string gender = "";
        private void xiugai_Load(object sender, EventArgs e)
        {
            //----------显示信息----------
            //读取学生姓名
            string name = string.Format("select stuName from student_stu where stuid={0}", center.row);
            SqlDataReader sqlData = DBHelper.GetDataReader(name);
            while (sqlData.Read())
            {
                textBox_student_name.Text = sqlData[0].ToString();
            }
            sqlData.Close();

            //读取学生性别
            string stu_gender = string.Format("select stuGender from student_stu where stuid={0}", center.row);
            SqlDataReader sqlData_gender = DBHelper.GetDataReader(stu_gender);
            
            while (sqlData_gender.Read())
            {
                gender = sqlData_gender[0].ToString();
            }
            sqlData_gender.Close();
            //判断性别
            if (gender == "男") radioButton_boy.Checked = true;
            else radioButton_gril.Checked = true;

            //读取学生日期
            string birthday = string.Format("select stuBirthday from student_stu where stuid={0}", center.row);
            SqlDataReader sqlData_birthday = DBHelper.GetDataReader(birthday);
            while (sqlData_birthday.Read())
            {
                textBox_birthday.Text = sqlData_birthday[0].ToString();
            }
            sqlData_birthday.Close();

            //读取学生班级
            string stu_class = string.Format("select stuClass from student_stu where stuid={0}", center.row);
            SqlDataReader sqlData_class = DBHelper.GetDataReader(stu_class);
            while (sqlData_class.Read())
            {
                comboBox1.Text = sqlData_class[0].ToString();
            }
            sqlData_class.Close();

            //读取学生照片
            string stu_photo = string.Format("select stuPhoto from student_stu where stuid={0}", center.row);
            SqlDataReader sqlData_photo = DBHelper.GetDataReader(stu_photo);
            while (sqlData_photo.Read())
            {
                textBox_photo.Text = sqlData_photo[0].ToString();
            }
            sqlData_photo.Close();
        }
    }
}
