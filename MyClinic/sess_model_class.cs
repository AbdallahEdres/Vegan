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
            cmd = new SqlCommand("select dr_id , dr_name from dr_info where dr_speciality =N'علاج طبيعي'", cn);
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
        public int set_sessions(int ptnt_id, int dr_id, DateTime date, string session_time,int payment,int payment_method ,int num_sessions,int weekly_sess)
        {
            if (check_free_appoint(date, session_time, dr_id) != -1)
            {
                return check_free_appoint(date, session_time, dr_id);
            }
            cn.Open();

            switch (payment_method)
            {
                case 0:
                    payment = 0;
                    break;
                case 1:
                    payment = payment / 6;
                    break;
            }
            if (weekly_sess == 1)
            {
                for(int i = 0; i < num_sessions; i++)
                {
                    if (i > 5)
                    {
                        payment = 0;
                    }
                    cmd = new SqlCommand("insert into sessions_details values (" + ptnt_id + "," + dr_id + ",'" + date.ToString("yyyy-MM-dd") + "','0" + session_time + ":00:00',0," + payment + ")", cn) ;
                    cmd.ExecuteNonQuery();
                    date = date.AddDays(7);
                }
            } else if (weekly_sess == 2)
            {
                if(date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    DateTime sec_date = date.AddDays(4);
                    for (int i = 0; i < num_sessions; i+=2)
                    {
                        if (i > 5)
                        {
                            payment = 0;
                        }
                        cmd = new SqlCommand("insert into sessions_details values (" + ptnt_id + "," + dr_id + ",'" + date.ToString("yyyy-MM-dd") + "','0" + session_time + ":00:00',0," + payment + ")", cn);
                        cmd.ExecuteNonQuery();
                        date = date.AddDays(7);
                        cmd = new SqlCommand("insert into sessions_details values (" + ptnt_id + "," + dr_id + ",'" + sec_date.ToString("yyyy-MM-dd") + "','0" + session_time + ":00:00',0," + payment + ")", cn);
                        cmd.ExecuteNonQuery();
                        sec_date = sec_date.AddDays(7);
                    }
                }else if(date.DayOfWeek == DayOfWeek.Wednesday || date.DayOfWeek == DayOfWeek.Thursday)
                {
                    DateTime sec_date = date.AddDays(3);
                    for (int i = 0; i < num_sessions; i += 2)
                    {
                        if (i > 5)
                        {
                            payment = 0;
                        }
                        cmd = new SqlCommand("insert into sessions_details values (" + ptnt_id + "," + dr_id + ",'" + date.ToString("yyyy-MM-dd") + "','0" + session_time + ":00:00',0," + payment + ")", cn);
                        cmd.ExecuteNonQuery();
                        date = date.AddDays(7);
                        cmd = new SqlCommand("insert into sessions_details values (" + ptnt_id + "," + dr_id + ",'" + sec_date.ToString("yyyy-MM-dd") + "','0" + session_time + ":00:00',0," + payment + ")", cn);
                        cmd.ExecuteNonQuery();
                        sec_date = sec_date.AddDays(7);
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("اختر يوم السبت/الاحد/الربعاء/الخميس");
                }
               
               
            }
            else if (weekly_sess == 3)
            {

                for (int i = 0; i < num_sessions; i++)
                {
                    if (i > 5)
                    {
                        payment = 0;
                    }
                    cmd = new SqlCommand("insert into sessions_details values (" + ptnt_id + "," + dr_id + ",'" + date.ToString("yyyy-MM-dd") + "','0" + session_time + ":00:00',0," + payment + ")", cn);
                    cmd.ExecuteNonQuery();
                    if (date.DayOfWeek == DayOfWeek.Wednesday || date.DayOfWeek == DayOfWeek.Thursday)
                    {
                        date = date.AddDays(3);
                    }else
                    {
                        date = date.AddDays(2);
                    }
                }
            }
            cn.Close();
            return -1;
        }
        // method to check for free appointments 
        public int check_free_appoint(DateTime date,string time,int dr_id)
        {
            int stat = -1;
            cn.Open();
            cmd = new SqlCommand("select  COUNT (*) from sessions_details where sess_date = '" + date.ToString("yyyy-MM-dd")+ "' and sess_time ='0" + time + ":00:00'", cn);
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
                    cmd = new SqlCommand("select * from sessions_details where sess_date = '" + date.ToString("yyyy-MM-dd") + "' and sess_time ='0" + time + ":00:00' and dr_id="+dr_id+"", cn);
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
            cmd = new SqlCommand("select * from sessions_veiw where ptnt_id= "+ptnt_id+" and stat=0", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(comming);
            return comming;
        }
        // method to edit sessions 
        public void edit_sess(DateTime old_date ,string old_time ,int dr_id,DateTime new_date,string new_time)
        {
            cn.Open();
            cmd =new SqlCommand("update sessions_details set sess_date='"+new_date.ToString("yyyy-MM-dd")+"' , sess_time ='0"+new_time+":00:00' , dr_id ="+dr_id+" where sess_date='"+old_date.ToString("yyyy-MM-dd")+"' and sess_time ='0"+old_time+":00:00'", cn);
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
            cmd = new SqlCommand("select * from sessions_veiw where ptnt_id= " + ptnt_id + " and stat=1", cn);
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
