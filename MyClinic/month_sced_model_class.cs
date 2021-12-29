using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MyClinic
{
    class month_sced_model_class
    {
        // decleartion of sql tools
        SqlConnection cn = conniction_class.cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;

        // var declearation

        //method to get all comming sessions  
        public DataTable get_all_sess(string cond)
        {
            DataTable all_sess = new DataTable();
            cmd = new SqlCommand("select * from sessions_veiw where sess_date>= '"+DateTime.Now.ToString("yyyy-MM-dd")+ "' and ptnt_name like N'" + cond+"%' and stat=0", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(all_sess);
            return all_sess;
        }
    }
}
