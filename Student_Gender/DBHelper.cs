using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Student_Gender
{
    class DBHelper
    {
        //创建连接字符串
        private static string shopping = "server=.;database=stuManage;Integrated Security=true;";
        //创建连接对象
        private static SqlConnection LianJie = null;

        //连接数据库
        public static void GetConnection()
        {
            //判断连接是否初始化
            if (LianJie == null)
            {
                LianJie = new SqlConnection(shopping);
            }
            //判断连接是否关闭
            if (LianJie.State == ConnectionState.Closed)
            {
                LianJie.Open();
            }
            //判断是否意外关闭
            if (LianJie.State == ConnectionState.Broken)
            {
                LianJie.Close();
                LianJie.Open();
            }
        }

        //查询多行多列
        public static SqlDataReader GetDataReader(string sql)
        {
            //调用数据库打开方法
            GetConnection();
            //创建连接对象
            SqlCommand sqlCommand = new SqlCommand(sql, LianJie);
            //当DataReader对象呗关闭时，自动关闭占用的链接对象
            return sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
        }

        //聚合函数查询
        public static int ExecuteScalar(string sql)
        {
            //调用数据库打开方法
            GetConnection();
            //创建连接对象
            SqlCommand sqlCommand = new SqlCommand(sql, LianJie);
            //执行查询行数方法并返回                                                             
            int line = int.Parse(sqlCommand.ExecuteScalar().ToString());
            return line;
        }

        //使用断开式查询多行多列
        public static DataTable GetDataTable(string tab)
        {
            //连接数据库
            GetConnection();
            //实例化sqlDataAdapter方法
             SqlDataAdapter adapter = new SqlDataAdapter(tab, LianJie);
            //实例化DataTable
            DataTable dt = new DataTable();
            //调用Fill方法
            adapter.Fill(dt);
            //返回表
            return dt;

        }
        //增删改方法
        public static bool ExecuteNonQuery(string sql)
        {
            //调用数据库打开方法
            GetConnection();
            //创建Command对象
            SqlCommand sqlCommand = new SqlCommand(sql, LianJie);
            //执行SQL并方法受影响行数
            int result = sqlCommand.ExecuteNonQuery();
            //关闭连接
            LianJie.Close();
            //影响行数值大于0返回true，否则为false
            return result > 0;
        }
    }
}
