using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClockiFyAMS.Modals;

namespace ClockiFyAMS.Database
{
    public class CustomDictionary
    {
        public int GoodEmployee { get; set; }
        public int BadEmployee { get; set; }

    }

    public class Read : config
    {
        public DataTable LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("IdNumber", typeof(int));
            dt.Columns.Add("UID", typeof(string));
            dt.Columns.Add("FullName", typeof(string));
            dt.Columns.Add("JobDescription", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("Performance", typeof(string));
            cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM tb_employee_details WHERE em_FullName LIKE @key ORDER BY em_Id";
            cmd.Parameters.AddWithValue("@key", $"%{key}%");
            cmd.Connection = con;
            PrepairConnectiom();

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    DataRow dr = dt.NewRow();
                    dr["IdNumber"] = reader.GetInt32("em_Id");
                    dr["UID"] = reader.GetString("em_uid");
                    dr["FullName"] = reader.GetString("em_FullName");
                    dr["JobDescription"] = reader.GetString("em_Description");
                    dr["Gender"] = reader.GetString("em_Gender");
                    dr["Address"] = reader.GetString("em_Address");
                    dr["Performance"] = string.Format("{0:0.00}%", reader.GetFloat("em_Performance"));
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }

        public int CheckID()
        {

            cmd = new MySqlCommand();
            cmd.CommandText = "SELECT COUNT(*)  FROM `tb_employee_details` WHERE em_uid = @uid";
            cmd.Parameters.AddWithValue("@uid", key);
            cmd.Connection = con;
            PrepairConnectiom();
            int idCount = int.Parse(cmd.ExecuteScalar().ToString());
            // MessageBox.Show(.ToString());
            return idCount;
        }

        public int GetEmployeeCount()
        {
            cmd = new MySqlCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM tb_employee_details";
            cmd.Connection = con;
            PrepairConnectiom();
            int count = int.Parse(cmd.ExecuteScalar().ToString());
            return count;
        }

        public DataTable LoadLogs()
        {
            var dt = new DataTable();
            dt.Columns.Add("UID", typeof(string));
            dt.Columns.Add("FullName", typeof(string));
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("TimeIn", typeof(string));
            dt.Columns.Add("TimeOut", typeof(string));
            dt.Columns.Add("TimeWorked", typeof(string));
            cmd = new MySqlCommand();

            string condition = string.IsNullOrEmpty(key) ? "1 ORDER BY Day LIMIT 50" : "Day LIKE @key";

            cmd.CommandText = $"SELECT `HashKey`, `Day`, `TimeIn`, `TimeOut`, `HoursWorked`, tb_employee_details.em_FullName FROM(`tb_dtr` INNER JOIN tb_employee_details ON tb_dtr.HashKey = tb_employee_details.em_uid) WHERE {condition}";
            cmd.Parameters.AddWithValue("@key", $"%{key}%");
            cmd.Connection = con;
            PrepairConnectiom();

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    DataRow dr = dt.NewRow();
                    dr["UID"] = reader.GetString("HashKey");
                    dr["FullName"] = reader.GetString("em_FullName");
                    dr["Date"] = reader.GetString("Day");
                    dr["TimeIn"] = reader.GetString("TimeIn");
                    dr["TimeOut"] = reader.GetString("TimeOut");
                    dr["TimeWorked"] = string.Format("{0:0.00}", reader.GetString("HoursWorked"));
                    dt.Rows.Add(dr);
                }
            }

            return dt;
        }

        public int TotalCount()
        {
            int i = 0;

            string sql = "SELECT COUNT(*) FROM tb_employee_details";
            cmd.CommandText = sql;
            cmd.Connection = con;
            PrepairConnectiom();

            i = int.Parse(cmd.ExecuteScalar().ToString());

            return i;
        }

        public List<int> AttendanceReportPreviewsDay()
        {
            var lst = new List<int>();

            string sql = "SELECT COUNT(CASE WHEN HoursWorked >= 8 THEN 1 ENd) as goodem,";
            sql += "COUNT(CASE WHEN HoursWorked < 8 THEN 1 ENd) as badem FROM tb_dtr ";
            sql += "WHERE Day = @day";
            cmd = new MySqlCommand();
            cmd.CommandText = sql;

            cmd.Parameters.AddWithValue("@day", DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd"));
            cmd.Connection = con;
            PrepairConnectiom();

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                lst.Add(reader.GetInt32(0));
                lst.Add(reader.GetInt32(1));
            }

            return lst;
        }


        public List<int> View6Days()
        {
            int a = 0;
            var lst = new List<int>();

            cmd.Parameters.Clear();

            PrepairConnectiom(); cmd.Connection = con;
            cmd.CommandText = "SELECT COUNT(*) FROM tb_dtr WHERE Day =  @day";
            cmd.Parameters.AddWithValue("@day", DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd"));
            int.TryParse(cmd.ExecuteScalar().ToString(), out a);
            lst.Add(a);
            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT COUNT(*) FROM tb_dtr WHERE Day =  @day";
            cmd.Parameters.AddWithValue("@day", DateTime.Now.AddDays(-2).ToString("yyyy-MM-dd"));
            int.TryParse(cmd.ExecuteScalar().ToString(), out a);
            lst.Add(a);
            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT COUNT(*) FROM tb_dtr WHERE Day =  @day";
            cmd.Parameters.AddWithValue("@day", DateTime.Now.AddDays(-3).ToString("yyyy-MM-dd"));
            int.TryParse(cmd.ExecuteScalar().ToString(), out a);
            lst.Add(a);
            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT COUNT(*) FROM tb_dtr WHERE Day =  @day";
            cmd.Parameters.AddWithValue("@day", DateTime.Now.AddDays(-4).ToString("yyyy-MM-dd"));
            int.TryParse(cmd.ExecuteScalar().ToString(), out a);
            lst.Add(a);
            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT COUNT(*) FROM tb_dtr WHERE Day =  @day";
            cmd.Parameters.AddWithValue("@day", DateTime.Now.AddDays(-5).ToString("yyyy-MM-dd"));
            int.TryParse(cmd.ExecuteScalar().ToString(), out a);
            lst.Add(a);
            cmd.Parameters.Clear();

            cmd.CommandText = "SELECT COUNT(*) FROM tb_dtr WHERE Day =  @day";
            cmd.Parameters.AddWithValue("@day", DateTime.Now.AddDays(-6).ToString("yyyy-MM-dd"));
            int.TryParse(cmd.ExecuteScalar().ToString(), out a);
            lst.Add(a);
            cmd.Parameters.Clear();

            return lst;
        }


        public List<CustomDictionary> View7Days()
        {
            var lst = new List<CustomDictionary>();

            cmd.Parameters.Clear();

            PrepairConnectiom(); cmd.Connection = con;

            string sql = "SELECT COUNT(CASE WHEN tb_dtr.HoursWorked >= 8 THEN 1 END) as good,";
            sql += "COUNT(CASE WHEN tb_dtr.HoursWorked < 8 THEN 1 END) as bad ";
            sql += "FROM tb_dtr WHERE Day >= @day1 AND Day < @day2 ORDER BY Day";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@day1", DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@day2", DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd"));
            MySqlDataReader mySqlDataReader = cmd.ExecuteReader();

            if (mySqlDataReader.HasRows)
            {
                mySqlDataReader.Read();
                lst.Add( new CustomDictionary { 
                    GoodEmployee = mySqlDataReader.GetInt32(0),
                    BadEmployee = mySqlDataReader.GetInt32(1)
                });
            }
            cmd.Parameters.Clear();

            mySqlDataReader.Close();
            mySqlDataReader.Dispose();

            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@day1", DateTime.Now.AddDays(-14).ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@day2", DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd"));
            mySqlDataReader = cmd.ExecuteReader();

            if (mySqlDataReader.HasRows)
            {
                mySqlDataReader.Read();
                lst.Add(new CustomDictionary
                {
                    GoodEmployee = mySqlDataReader.GetInt32(0),
                    BadEmployee = mySqlDataReader.GetInt32(1)
                });
            }
            cmd.Parameters.Clear();

            mySqlDataReader.Close();
            mySqlDataReader.Dispose();

            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@day1", DateTime.Now.AddDays(-21).ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@day2", DateTime.Now.AddDays(-14).ToString("yyyy-MM-dd"));
            mySqlDataReader = cmd.ExecuteReader();

            if (mySqlDataReader.HasRows)
            {
                mySqlDataReader.Read();
                lst.Add(new CustomDictionary
                {
                    GoodEmployee = mySqlDataReader.GetInt32(0),
                    BadEmployee = mySqlDataReader.GetInt32(1)
                });
            }
            cmd.Parameters.Clear();

            mySqlDataReader.Close();
            mySqlDataReader.Dispose();

            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@day1", DateTime.Now.AddDays(-28).ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@day2", DateTime.Now.AddDays(-21).ToString("yyyy-MM-dd"));
            mySqlDataReader = cmd.ExecuteReader();

            if (mySqlDataReader.HasRows)
            {
                mySqlDataReader.Read();
                lst.Add(new CustomDictionary
                {
                    GoodEmployee = mySqlDataReader.GetInt32(0),
                    BadEmployee = mySqlDataReader.GetInt32(1)
                });
            }
            cmd.Parameters.Clear();

            mySqlDataReader.Close();
            mySqlDataReader.Dispose();

            return lst;
        }

        public List<Account> LogIn()
        {
            List<Account> lst = new List<Account>();   

            cmd = new MySqlCommand();
            PrepairConnectiom(); cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM `tb_role` WHERE Username = @uname AND Password = @pw";
            cmd.Parameters.AddWithValue("@uname", config.AccountObj.user);
            cmd.Parameters.AddWithValue("@pw", config.AccountObj.passwd);

            MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
            if (mySqlDataReader.HasRows)
            {
                while (mySqlDataReader.Read())
                {
                    lst.Add(new Account
                    {
                        id = mySqlDataReader.GetInt32(0),
                        user = mySqlDataReader.GetString(1),
                        passwd = mySqlDataReader.GetString(2)
                    }); 
                }
            }

            return lst;
        }
    }
}