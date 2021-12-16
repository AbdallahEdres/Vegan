using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace MyClinic
{
    // handel the connection between doctors_cont and data base
    class dr_model_class
    {
        // deffintion of connecction 
        SqlConnection cn = conniction_class.cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;


        //method of adding new doctor 
        public  void add_new_dr(string name ,string phone ,int group ,string specialty)
        {
            cn.Open();
            cmd = new SqlCommand("insert into dr_info values (N'"+name+"',N'"+phone+"',"+group+",N'"+specialty+"')", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        // method to edit dr_info 
        public void edit_dr (int id,string name, string phone, int group, string specialty)
        {
            cn.Open();
            cmd = new SqlCommand("update dr_info set dr_name=N'"+name+"',dr_phone=N'"+phone+"',dr_group="+group+" ,dr_speciality=N'"+specialty+"' where dr_id ="+id+"", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        // method to get dr_info 
        public DataTable get_dr_list()
        {
            DataTable dr_list = new DataTable();
            cmd = new SqlCommand("select dr_id, dr_name ,dr_phone from dr_info ", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dr_list);

            return dr_list;
        }

        // method to get doctor's info
        public void get_dr_info(int id , ref string name, ref string phone ,ref string group,ref string speciality)
        {
            cn.Open();
            cmd = new SqlCommand("select * from dr_info where dr_id="+id+"",cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                name = dr[1].ToString();
                phone = dr[2].ToString();
                speciality = dr[4].ToString();
                if (Convert.ToInt32(dr[3]) == 0)
                {
                    group = "السبت , الإثنين , الأربعاء";
                }else if (Convert.ToInt32(dr[3]) == 1)
                {
                    group = "الأحد ,الثلاثاء ,الخميس";
                }else if (Convert.ToInt32(dr[3]) == 2)
                {
                    group = "كل يوم";
                }
            }
            cn.Close();
        }

    }
}
