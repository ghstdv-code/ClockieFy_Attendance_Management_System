using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockiFyAMS.Database
{
    public class Delete : config
    {
        public void RemovePerson()
        {
            cmd = new MySqlCommand();
            cmd.CommandText = "DELETE FROM `tb_employee_details` WHERE em_uid = @uid";
            cmd.Parameters.AddWithValue("@uid", WorkerObj.UID);
            cmd.Connection = con;
            PrepairConnectiom();

            cmd.ExecuteNonQuery();
        }

        public void RemoveRecord()
        {
            cmd = new MySqlCommand();
            cmd.CommandText = "DELETE FROM `tb_dtr` WHERE HashKey = @uid";
            cmd.Parameters.AddWithValue("@uid", AttObj.UID);
            cmd.Connection = con;
            PrepairConnectiom();

            cmd.ExecuteNonQuery();
        }
    }
}
