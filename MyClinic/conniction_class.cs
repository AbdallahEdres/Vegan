using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyClinic
{
    // conniction to the data base 
    public static class conniction_class
    {
        public static SqlConnection cn = new SqlConnection("server = . ; DataBase=my_clinic;integrated security = true");
    }
}
