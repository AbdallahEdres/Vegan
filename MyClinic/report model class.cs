using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace MyClinic
{
    // class to connect report controller with data base

    class report_model_class
    {
        // declearation of sql tools
        SqlConnection cn = conniction_class.cn;
        SqlCommand cmd;
        SqlDataReader dr;
        #region report controler methods
        //method to get total 
        public string get_total_money(DateTime date )
        {
            int total=0;
            cn.Open();
            cmd = new SqlCommand("select payment from exam where sess_date between '" + date.ToString("yyyy-MM-dd") + "' and '" + date.AddMonths(1).ToString("yyyy-MM-dd") + "' union all select payment from sessions_details where sess_date between '" + date.ToString("yyyy-MM-dd") + "' and '" + date.AddMonths(1).ToString("yyyy-MM-dd") + "'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                cmd = new SqlCommand("select sum (payment) from (select payment from exam where sess_date between '" + date.ToString("yyyy-MM-dd") + "' and '" + date.AddMonths(1).ToString("yyyy-MM-dd") + "'  union all select payment  from sessions_details where sess_date between '" + date.ToString("yyyy-MM-dd") + "' and '" + date.AddMonths(1).ToString("yyyy-MM-dd") + "') x", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr[0] != null)
                    {
                        total += Convert.ToInt32(dr[0]);
                    }
                }
                dr.Close();

            }
            dr.Close();
            cn.Close();
            return total.ToString();
        }
        // method to get number of patients in month
        public string get_num_ptnt (DateTime date)
        {
            int num = 0;
            cn.Open();
            cmd = new SqlCommand(" select count  (*) from  (select ptnt_id from exam where sess_date between '" + date.ToString("yyyy-MM-dd") + "' and '" + date.AddMonths(1).ToString("yyyy-MM-dd") + "' union select ptnt_id from sessions_details where sess_date between '" + date.ToString("yyyy-MM-dd") + "' and '" + date.AddMonths(1).ToString("yyyy-MM-dd") + "') x", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                num += Convert.ToInt32(dr[0]);
            }
            dr.Close();
            cn.Close();
            return num.ToString();
        }
        //method to get sessions number 
        public string get_sess_num(DateTime date)
        {
            string num="0";
            cn.Open();
            cmd = new SqlCommand("select count (*) from sessions_details where sess_date between '" + date.ToString("yyyy-MM-dd") + "' and '" + date.AddMonths(1).ToString("yyyy-MM-dd") + "'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                num = dr[0].ToString();

            }

            dr.Close();
            cn.Close();
            if (num == "")
            {
                num = "0";
            }
            return num;
        }
        //method to get sessions income 
        public string get_sess_incom(DateTime date)
        {
            string num = "0";
            cn.Open();
            cmd = new SqlCommand("select sum (payment)from sessions_details where sess_date between '" + date.ToString("yyyy-MM-dd") + "' and '" + date.AddMonths(1).ToString("yyyy-MM-dd") + "'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                num = dr[0].ToString();
            }
            dr.Close();
            cn.Close();
            if (num == "")
            {
                num = "0";
            }
            return num;
        }
        //method to get nutretion exams income 
        public string get_nut_incom(DateTime date)
        {
            string num = "0";
            cn.Open();
            cmd = new SqlCommand("select sum (payment)from exam where sess_date between '" + date.ToString("yyyy-MM-dd") + "' and '" + date.AddMonths(1).ToString("yyyy-MM-dd") + "'and exam_type=N'تغذية' ", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                num = dr[0].ToString();

            }
            dr.Close();
            cn.Close();
            if (num == "")
            {
                num = "0";
            }
            return num;
        }
        //method to get pysical exams income 
        public string get_phys_incom(DateTime date)
        {
            string num = "0";
            cn.Open();
            cmd = new SqlCommand("select sum (payment) from exam where sess_date between '" + date.ToString("yyyy-MM-dd") + "' and '" + date.AddMonths(1).ToString("yyyy-MM-dd") + "'and exam_type=N'علاج طبيعي' ", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                num = dr[0].ToString();

            }
            dr.Close();
            cn.Close();
            if (num == "")
            {
                num = "0";
            }
            return num;
        }
        //method to get pysical exams number 
        public string get_phys_num(DateTime date)
        {
            string num = "0";
            cn.Open();
            cmd = new SqlCommand("select count (*) from exam where sess_date between '" + date.ToString("yyyy-MM-dd") + "' and '" + date.AddMonths(1).ToString("yyyy-MM-dd") + "'and exam_type=N'علاج طبيعي' ", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                num = dr[0].ToString();

            }
            dr.Close();
            cn.Close();
            if (num == "")
            {
                num = "0";
            }
            return num;
        }
        //method to get nutrition exams number 
        public string get_nut_num(DateTime date)
        {
            string num = "0";
            cn.Open();
            cmd = new SqlCommand("select count (*) from exam where sess_date between '" + date.ToString("yyyy-MM-dd") + "' and '" + date.AddMonths(1).ToString("yyyy-MM-dd") + "'and exam_type=N'تغذية' ", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                num = dr[0].ToString();

            }
            dr.Close();
            cn.Close();
            if (num == "")
            {
                num = "0";
            }
            return num;
        }
        #endregion

        #region report_dr_factory methods
        // method to get list of doctors ids
        public List<int> get_ids()
        {
            List<int> id = new List<int>();
            cn.Open();
            cmd = new SqlCommand("select dr_id from dr_info where dr_speciality =N'علاج طبيعي'", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id.Add(Convert.ToInt32(dr[0]));
            }
            dr.Close();
            cn.Close();
            return id;

        }

        //method to get dr_name
        public string get_dr_name (int id)
        {
            string name="";
            cn.Open();
            cmd = new SqlCommand("select dr_name from dr_info where dr_id ="+id+"", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                name = dr[0].ToString();

            }
            dr.Close();
            cn.Close();
            return name;
        }
        //method to get doctors sessions number
        public string get_dr_sess_num(int dr_id ,DateTime date)
        {
            string num = "0";
            cn.Open();
            cmd = new SqlCommand("select count (*) from sessions_details where dr_id = "+dr_id+ " and sess_date between '" + date.ToString("yyyy-MM-dd") + "' and '" + date.AddMonths(1).ToString("yyyy-MM-dd") + "'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                num = dr[0].ToString();
            }
            dr.Close();
            cn.Close();
            return num;
        }
        // method to get number of patients for each doctor 
        public string get_ptnt_val(int dr_id ,DateTime date)
        {
            string num = "0";
            cn.Open();
            cmd = new SqlCommand("select count (distinct ptnt_id) from sessions_details where dr_id = " + dr_id + " and sess_date between '" + date.ToString("yyyy-MM-dd") + "' and '" + date.AddMonths(1).ToString("yyyy-MM-dd") + "'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                num = dr[0].ToString();
            }
            dr.Close();
            cn.Close();
            return num;
        } 
        #endregion
    }
}
