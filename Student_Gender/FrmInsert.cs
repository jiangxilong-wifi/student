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
    public partial class FrmInsert : Form
    {
        public FrmInsert()
        {
            InitializeComponent();
        }

        private void FrmInsert_Load(object sender, EventArgs e)
        {
            select();
            dataGridView1.CurrentCell = null;
        }

        //------------封装查询方法--------------------
        private void select()
        {
            //新建连接字符串
            string str = "select * from student_stu";
            //查询数据传给dataTable
            DataTable table = DBHelper.GetDataTable(str);
            //显示表
            dataGridView1.DataSource = table;
        }

        //添加学生信息
        private void button_add_Click(object sender, EventArgs e)
        {
           
            //------------获取所有填入内容---------
            //获取姓名
            string stuname = textBox_name.Text;
            //获取班级
            string stuclass = textBox_class.Text;
            //获取性别
            string stugender;
            if (radioButton1.Checked)
            {
                stugender = radioButton1.Text;
            }
            else
            {
                stugender = radioButton2.Text;
            }
            //获取照片
            string stuphoto = textBox_photo.Text;
            //获取出生日期
            string stubirthday = textBox_birthday.Text;

            //新增数据
            string add = string.Format("insert student_stu(stuName,stuGender,stuBirthday,stuClass,stuPhoto) values('{0}','{1}','{2}','{3}','{4}')", stuname,stugender,stubirthday,stuclass,stuphoto);
            DBHelper.ExecuteNonQuery(add);
            //更新显示数据
            select();
        }

        //右键删除
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获取用户选择的ID
            int rows = int.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
            DialogResult result = MessageBox.Show("是否删除", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                //删除数据
                string delete = string.Format("delete from student_stu where stuid={0}", rows);
                //执行删除方法
                DBHelper.ExecuteNonQuery(delete);
                //更新数据
                select();
            }
        }


        //删除学生信息
        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否删除", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                //获取用户选择的ID
                int rows = int.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                //删除数据
                string delete = string.Format("delete from student_stu where stuid={0}",rows);
                //执行删除方法
                DBHelper.ExecuteNonQuery(delete);
                //更新数据
                select();
            }  
        }

        //修改学生信息
        private void button_alter_Click(object sender, EventArgs e)
        {
            //获取姓名
            string stuname = textBox_name.Text;
            //获取班级
            string stuclass = textBox_class.Text;
            //获取日期
            string stubirthday = textBox_birthday.Text;
            //获取照片
            string stuphoto = textBox_photo.Text;
            //获取性别
            string gender = "";
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            //获取ID
            int id = int.Parse(label_id.Text);
            //修改语句
            string update = string.Format("update student_stu set stuName='{0}',stuGender='{1}',stuBirthday='{2}',stuClass='{3}',stuphoto='{4}' where stuid={5}"
                , stuname,gender, stubirthday, stuclass, stuphoto, id);
            //执行修改操作
            if (DBHelper.ExecuteNonQuery(update))
            {
               //刷新显示信息
               DialogResult result = MessageBox.Show("修改成功");
               select();

            }
           
        }
        //获取选中信息
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //把值传给控件
            textBox_name.Text = dataGridView1.SelectedRows[0].Cells["学生姓名"].Value.ToString();
            textBox_class.Text = dataGridView1.SelectedRows[0].Cells["班级"].Value.ToString();
            
            if(dataGridView1.SelectedRows[0].Cells["学生性别"].Value.ToString() == "男")
            {
                radioButton1.Checked = true;
                
            }
            else
            {
                radioButton2.Checked = true;
                
            }
            textBox_photo.Text = dataGridView1.SelectedRows[0].Cells["号码"].Value.ToString();
            textBox_birthday.Text = dataGridView1.SelectedRows[0].Cells["年龄"].Value.ToString();
            label_id.Text = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
        }



    }
}
