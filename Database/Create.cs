using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ClockiFyAMS.Database
{
    public class Create : config
    {
       public void AddPerson()
       {
            cmd = new MySqlCommand();
            cmd.CommandText = "INSERT INTO `tb_employee_details`(`em_uid`, `em_FullName`, `em_Description`, `em_Gender`, `em_Address`) VALUES (@uid, @fullname, @jobdesc, @gender, @address)";
            cmd.Parameters.AddWithValue("@uid", WorkerObj.UID);
            cmd.Parameters.AddWithValue("@fullname", WorkerObj.FullName);
            cmd.Parameters.AddWithValue("@jobdesc", WorkerObj.JobDescription);
            cmd.Parameters.AddWithValue("@gender", WorkerObj.Gender == "MALE" ? true : false);
            cmd.Parameters.AddWithValue("@address", WorkerObj.Address);
            cmd.Connection = con;
            PrepairConnectiom();

            cmd.ExecuteNonQuery();
        }

    }
}
