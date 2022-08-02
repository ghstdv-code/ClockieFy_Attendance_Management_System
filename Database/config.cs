using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ClockiFyAMS.Modals;

namespace ClockiFyAMS.Database
{
    public class config
    {
        public MySqlConnection con = new MySqlConnection($"server={"localhost"}; uid={"root"}; password = {""} ; database = db_attendance");
        public static MySqlCommand cmd = default(MySqlCommand);
        public static string query;
        public static string key;

        public static Workers WorkerObj;
        public static Attendance AttObj;
        public static Account AccountObj;
        public void PrepairConnectiom()
        {
            try
            {
                con.Open();
            }
            catch { }
        }
    }
}
