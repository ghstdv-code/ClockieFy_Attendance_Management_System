using MySql.Data.MySqlClient;

namespace ClockiFyAMS.Database
{
    public class Update : config
    {
        public void UpdatePerson()
        {
            cmd = new MySqlCommand();
            string sql = "UPDATE `tb_employee_details` SET `em_FullName`=@fullname,`em_Description`=@jobdesc,`em_Gender`=@gender,`em_Address`=@address";
            sql += " WHERE em_uid = @uid";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@uid", WorkerObj.UID);
            cmd.Parameters.AddWithValue("@fullname", WorkerObj.FullName);
            cmd.Parameters.AddWithValue("@jobdesc", WorkerObj.JobDescription);
            cmd.Parameters.AddWithValue("@gender", WorkerObj.Gender == "MALE" ? true : false);
            cmd.Parameters.AddWithValue("@address", WorkerObj.Address);
            cmd.Connection = con;
            PrepairConnectiom();

            cmd.ExecuteNonQuery();
        }

        public void UpdateAccount()
        {
            cmd = new MySqlCommand();
            string sql = "UPDATE `tb_role` SET `Username`=@uname,`Password`=@pw WHERE id = @id";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", AccountObj.id);
            cmd.Parameters.AddWithValue("@uname", AccountObj.user);
            cmd.Parameters.AddWithValue("@pw", AccountObj.passwd);
            cmd.Connection = con;
            PrepairConnectiom();

            cmd.ExecuteNonQuery();
        }

    }
}
