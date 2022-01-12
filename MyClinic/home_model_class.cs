using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MyClinic
{
    // class to connect the home controller with database
    class home_model_class
    {
        // decleartion of sql tools
        SqlConnection cn = conniction_class.cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;

        // var declearation

        //method to get count of patient today 
        public string get_count_ptnt()
        {
            string count="";
            cn.Open();
            cmd = new SqlCommand("select count (*) from sessions_details where sess_date='"+DateTime.Now.ToString("yyyy-MM-dd")+"'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                count = dr[0].ToString();
            }
            dr.Close();
            cn.Close();
            return count;
        }
        // method to get doctors and patients for every hour
        public DataTable get_dr_ptnt(string hr)
        {
            DataTable dr_ptnt = new DataTable();
            cmd = new SqlCommand("select ptnt_name ,dr_name from sessions_veiw where sess_date ='" + DateTime.Now.ToString("yyyy-MM-dd")+"' and sess_time ='"+hr+"'and stat=0", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dr_ptnt);
            dr_ptnt.Columns[0].ColumnName = "الحالة";
            dr_ptnt.Columns[1].ColumnName = "الطبيب";
            return dr_ptnt;
        }

        // method to get day work hrs
        public List<string> get_hrs(DateTime date)
        {
            List<string> hrs = new List<string>();
            cn.Open();
            cmd = new SqlCommand("select distinct (sess_time) from sessions_details where sess_date ='"+date.ToString("yyyy-MM-dd")+"' and stat=0", cn) ;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                hrs.Add(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
            return hrs;
        }
    }
}
