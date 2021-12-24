using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MyClinic
{
    // class to connect the sessions controler with database

    class sess_model_class
    {
        // decleartion of sql tools
        SqlConnection cn = conniction_class.cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        // var declearation

        // method to get patients list 
        public DataTable get_ptnt_list(string search)
        {
            DataTable patients_list;
            patients_list = new DataTable();
            cmd = new SqlCommand("select ptnt_id , ptnt_name ,ptnt_phone from ptnt_info where ptnt_name like N'" + search + "%' or ptnt_phone like N'" + search + "%'", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(patients_list);
            return patients_list;
        }

        //method to get docotr's names & id
        public List<List<string>> get_dr_list()
        {
            List< List<string>> dr_details = new List<List<string>> ();
            List<string> dr_names = new List<string>();
            List<string> dr_id = new List<string>();
            cn.Open();
            cmd = new SqlCommand("select dr_id , dr_name from dr_info", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dr_id.Add(dr[0].ToString());
                dr_names.Add(dr[1].ToString());
            }
            cn.Close();
            dr_details.Add(dr_id);
            dr_details.Add(dr_names);
            return dr_details;
        }
        // method to get doctor's previous appointments
        public DataTable get_dr_pre_appoints(string dr_id)
        {
            DataTable dr_appoint = new DataTable();
            cmd = new SqlCommand("select sess_date, sess_time from sessions_details where dr_id="+dr_id+"", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dr_appoint);
            return dr_appoint;
        }
    }
}
