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

        // car declearation
        DataTable patients_list;
        DataTable exam_list;

        //method to add new examination
        public void add_exam(int ptnt_id,DateTime date,string time,int pay,string type)
        {
            cn.Open();
            cmd = new SqlCommand("insert into exam values ("+ptnt_id+",'"+date.ToString("yyyy-MM-dd")+"','"+time+"',0,"+pay+",N'"+type+"')", cn);
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
        public DataTable get_exam(string search,string cond)
        {
            exam_list = new DataTable();
            cmd = new SqlCommand("select * from exam_veiw where( ptnt_name like N'"+search+"%' or ptnt_phone like N'"+search+"%')"+cond+" and stat=0", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(exam_list);
            return exam_list;
        }
    }
}
