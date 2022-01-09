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
        public List<List<string>> get_dr_list(string cond)
        {
            List< List<string>> dr_details = new List<List<string>> ();
            List<string> dr_names = new List<string>();
            List<string> dr_id = new List<string>();
            cn.Open();
            cmd = new SqlCommand("select dr_id , dr_name from dr_info where dr_speciality =N'علاج طبيعي'" +cond, cn);
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
            cmd = new SqlCommand("select sess_date, sess_time from sessions_details where dr_id="+dr_id+" and stat=0", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dr_appoint);
            return dr_appoint;
        }
        // method to set sessions 
        public int set_sessions(int ptnt_id, int dr_id, string date, string session_time,int payment)
        {
            cn.Open();
            cmd = new SqlCommand("insert into sessions_details values("+ptnt_id+","+dr_id+",'"+date+"','"+session_time+"',0,"+payment+")", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            return -1;
        }
        // method to check for free appointments 
        public int check_free_appoint(string date,string time,int dr_id)
        {
            int stat = -1;
            cn.Open();
            cmd = new SqlCommand("select  COUNT (*) from sessions_details where sess_date = '" + date+ "' and sess_time ='" + time + "'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (Convert.ToInt32(dr[0]) >= 3)
                {
                    stat= 0;
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("select * from sessions_details where sess_date = '" + date+ "' and sess_time ='" + time + "' and dr_id="+dr_id+"", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        stat = 1;
                        dr.Close();
                    }
                }
            }
            dr.Close();
            cn.Close();
            return stat;
        }
        //method to get patients list of comming sessions
        public DataTable get_comming(int ptnt_id)
        {
            DataTable comming = new DataTable();
            cmd = new SqlCommand("select * from sessions_veiw where ptnt_id= "+ptnt_id+ " and sess_date>='"+DateTime.Now.ToString("yyyy-MM-dd")+"' and stat=0", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(comming);
            return comming;
        }
        // method to edit sessions 
        public void edit_sess(DateTime old_date ,string old_time ,int dr_id,DateTime new_date,string new_time)
        {
            cn.Open();
            cmd =new SqlCommand("update sessions_details set sess_date='"+new_date.ToString("yyyy-MM-dd")+"' , sess_time ='"+new_time+"' , dr_id ="+dr_id+" where sess_date='"+old_date.ToString("yyyy-MM-dd")+"' and sess_time ='"+old_time+"'", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        //method to change session status
        public void change_stat(string date ,string time, int ptnt_id)
        {
            cn.Open();
            cmd = new SqlCommand("update sessions_details set stat=1 where ptnt_id=" + ptnt_id + " and sess_date='" + date + "' and sess_time ='" + time + "'", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        //method to get previous sessions 
        public DataTable get_prev(int ptnt_id)
        {
            DataTable comming = new DataTable();
            cmd = new SqlCommand("select * from sessions_veiw where ptnt_id= " + ptnt_id + " and  (sess_date<'" + DateTime.Now.ToString("yyyy-MM-dd") + "' or stat=1)", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(comming);
            return comming;
        }
        //method to edit payment for session
        public void set_pay(int pay, string date, string time, int ptnt_id)
        {
            cn.Open();
            cmd = new SqlCommand("update sessions_details set payment="+pay+" where ptnt_id=" + ptnt_id + " and sess_date='" + date + "' and sess_time ='" + time + "'", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
