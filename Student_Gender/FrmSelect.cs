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
    public partial class FrmSelect : Form
    {
        public FrmSelect()
        {
            InitializeComponent();
        }

        private void FrmSelect_Load_1(object sender, EventArgs e)
        {
           
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
        

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //提示删除信息
            DialogResult result = MessageBox.Show("确认删除吗", "提示", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //获取用户选择的ID
                int rows=int.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                //对当前数据进行删除
                string str = string.Format("delete  from student_stu where stuid='{0}'",rows);
                DBHelper.ExecuteNonQuery(str);
                select();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string condition_select = "select * from student_stu where ";
            if (comboBox_condition.Text == "姓名") condition_select += "stuName";
            else if (comboBox_condition.Text == "班级") condition_select += "stuClass";
            else if (comboBox_condition.Text == "性别") condition_select += "stuGender";
            else if (comboBox_condition.Text == "日期") condition_select += "stuBirthday";

            //拼接查询字符串
            condition_select = condition_select + " like '%" + textBox_condition.Text + "%'";
            //执行查询
            DataTable data = DBHelper.GetDataTable(condition_select);
            //显示数据
            dataGridView1.DataSource = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string select_duo = "select * from student_stu where ";
            if (textBox1.Text != "")
            {
                select_duo = select_duo+" stuName like '%"+textBox1.Text+"%' ";
            }
            else
            {
                if (comboBox1.Text != "")
                {
                    select_duo = select_duo + " stuClass  like '" + comboBox1.Text + "'";
                }
                else
                {
                    MessageBox.Show("错误，查询条件不可均为空", "提示");
                }
            }
            if(comboBox1.Text != "" && textBox1.Text!="")
            {
                select_duo = select_duo + " and  stuClass  like '"+comboBox1.Text+"'";
            }

            
            //执行查询
            DataTable data = DBHelper.GetDataTable(select_duo);
            //显示数据
            dataGridView1.DataSource = data;
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            frminsert_2 frmist = new frminsert_2();
            frmist.ShowDialog();
            
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获取用户选择的ID
            center.row = int.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
            xiugai xg = new xiugai();
            xg.ShowDialog();
            
        }
    }
}
