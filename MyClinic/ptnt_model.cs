using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MyClinic
{
    // clss to connect patient controler with database
    class ptnt_model
    {
        //declearation of sql tools
        SqlConnection cn = conniction_class.cn;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable patients_list;


        // method to add patient 
        public void add_patient(string name , string phone, string adress , int age , string type )
        {
            cn.Open();
            cmd = new SqlCommand("insert into ptnt_info values (N'"+name+ "',N'" + adress + "',N'" + phone+"',"+age+",N'"+type+"')", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
         // method to get patients list 
        public DataTable get_ptnt_list(string search)
        {
            patients_list = new DataTable();
            cmd = new SqlCommand("select ptnt_id , ptnt_name ,ptnt_phone from ptnt_info where ptnt_name like N'" + search + "%' or ptnt_phone like N'" + search + "%'", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(patients_list);
            return patients_list;
        }
        // method to get patients details
        public void get_ptnt_details(int ptnt_id , ref string name , ref string phone, ref string adress, ref string type,ref int age )
        {
            cn.Open();
            cmd = new SqlCommand("select * from ptnt_info where ptnt_id ="+ptnt_id+"", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                name = dr[1].ToString();
                adress = dr[2].ToString();
                phone = dr[3].ToString();
                age = Convert.ToInt32(dr[4]);
                type = dr[5].ToString();
               
            }
            cn.Close();
        }
        // method to edit patient info 
        public void edit_ptnt_info (int ptnt_id,   string name,   string phone,   string adress,   string type,   int age,   DateTime date)
        {
            cn.Open();
            cmd = new SqlCommand("update ptnt_info set ptnt_name=N'"+name+"',ptnt_adress=N'"+adress+"',ptnt_phone=N'"+phone+"',ptnt_age="+age+",ptnt_type=N'"+type+"' where ptnt_id="+ptnt_id+"", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public int get_new_ptnt_id(string name ,string phone)
        {
            int id = -1;
            cn.Open();
            cmd = new SqlCommand("select ptnt_id from ptnt_info where ptnt_name=N'"+name+"'and ptnt_phone='"+phone+"'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            cn.Close();
            return id;
        }
        public string get_date(int ptnt_id)
        {
            string date = "";
            cn.Open();
            cmd = new SqlCommand("select max (sess_date) from exam where ptnt_id="+ptnt_id+"", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read()&&dr[0].ToString()!="")
            {
                date = Convert.ToDateTime(dr[0]).ToString("dd-MM-yyyy");

            }
            dr.Close();
            cn.Close();
            return date;
        }
        //method to get patients list of  sessions
        public DataTable get_sess(int ptnt_id)
        {
            DataTable comming = new DataTable();
            cmd = new SqlCommand("select * from sessions_veiw where ptnt_id= " + ptnt_id, cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(comming);
            return comming;
        }
    }
}
