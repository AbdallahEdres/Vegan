using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MyClinic
{
    // class to connect the exam controler with database

    class exam_model_class
    {
        // decleartion of sql tools
        SqlConnection cn = conniction_class.cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;

        // var declearation
        DataTable patients_list;
        DataTable exam_list;

        //method to add new examination
        public void add_exam(int ptnt_id,DateTime date,string time,int pay,string type)
        {
            cn.Open();
            cmd = new SqlCommand("insert into exam values ("+ptnt_id+",'"+date.ToString("yyyy-MM-dd")+"',N'"+time+"',0,"+pay+",N'"+type+"')", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

               
        // method to get patients list 
        public DataTable get_ptnt_list(string search)
        {
            patients_list = new DataTable();
            cmd = new SqlCommand("select ptnt_id , ptnt_name ,ptnt_phone from ptnt_info where ptnt_name like N'"+search+"%' or ptnt_phone like N'"+search+"%'", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(patients_list);
            return patients_list;
        }

        // method to get examinations
        public DataTable get_exam(string search,string cond,int stat)
        {
            exam_list = new DataTable();
            cmd = new SqlCommand("select * from exam_veiw where( ptnt_name like N'"+search+"%' or ptnt_phone like N'"+search+"%')"+cond+" and stat="+stat+"", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(exam_list);
            return exam_list;
        }
        // method to update examination status 
        public void edit_stat(string date , string time)
        {
            cn.Open();
            cmd = new SqlCommand("update exam set stat=1 where sess_date ='"+date+"' and sess_time='"+time+"'",cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        // method to check if this appointment is free 
        public bool check_date_time(string date, string time)
        {
            bool stat = true;
            cn.Open();
            cmd = new SqlCommand("select * from exam where sess_date='"+date+"' and sess_time='"+time+"'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                stat = false;
            }
            cn.Close();
            return stat;
        }
        // method to edit exam date 
        public void edit_date(string new_date,string old_date , string time)
        {
            cn.Open();
            cmd = new SqlCommand("update exam set sess_date = '"+new_date+ "' where sess_date='" +old_date + "' and sess_time='" + time + "'", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        //method to edit time 
        public void edit_time(string new_time, string old_date, string time)
        {
            cn.Open();
            cmd = new SqlCommand("update exam set sess_time = '" + new_time + "' where sess_date='" + old_date + "' and sess_time='" + time + "'", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        // method to delete an appointment
        public void delete_exam( string old_date, string time)
        {
            cn.Open();
            cmd = new SqlCommand("delete from exam where sess_date='" + old_date + "' and sess_time='" + time + "'", cn);
            cmd.ExecuteNonQuery();
            cn.Close();

        }
        //method to edit exam payment 
        public void pay_exam(int id , DateTime date,int valu)
        {
            cn.Open();
            cmd = new SqlCommand("update exam set payment = "+valu+" where ptnt_id="+id+" and sess_date='"+date.ToString("yyyy-MM-dd")+"'", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
