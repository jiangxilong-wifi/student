using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Gender
{
    public partial class frminsert_2 : Form
    {
        public frminsert_2()
        {
            InitializeComponent();
        }

        //添加点击
        private void button1_Click(object sender, EventArgs e)
        {
            //判断单选值
            string gender = "";
            if (radioButton_boy.Checked) gender = radioButton_boy.Text;
            else gender = radioButton_gril.Text;

            //判断班级
            string student_class = "";
            if (comboBox1.Text == "2019173808") student_class = comboBox1.Text;
            else if(comboBox1.Text == "2019173807") student_class = comboBox1.Text;
            else if(comboBox1.Text == "2019182901") student_class = comboBox1.Text;
            string str = string.Format("insert student_stu(stuName,stuGender,stuBirthday,stuClass,stuPhoto) values('{0}','{1}','{2}','{3}','{4}')",textBox_student_name.Text,gender,textBox_birthday.Text, student_class,textBox_photo.Text);
            if (DBHelper.ExecuteNonQuery(str))
            {
                MessageBox.Show("添加成功");
                this.Close();
            }
            
        }
    }
}
