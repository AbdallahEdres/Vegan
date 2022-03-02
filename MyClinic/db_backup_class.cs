using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyClinic
{
    public static class db_backup_class
    {
        public static SqlCommand cmd;
        public static SqlConnection cn = new SqlConnection("server = WINCTRL-VO0OANJ ;integrated security = true");
        public static void back_up()
        {
            cn.Open();
            cmd = new SqlCommand("BACKUP DATABASE my_clinic TO DISK = 'D:\\my_clinic.bak'; ", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static void restore()
        {
            cn.Open();
            cmd = new SqlCommand("RESTORE DATABASE my_clinic FROM DISK =  'D:\\my_clinic.bak'; ", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
