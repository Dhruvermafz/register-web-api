using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace register_backend_app.Models
{
    public class EmployeeDb
    {
        //declare conncection string 
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        //return list of all employess 
        //public List<Employee> ListAll()
        //{
        //    List<Employee> lst = new List<Employee>();
            
        //    using (SqlConnection con = SqlCommand("SelectEmployee", con);

        //}
    }
}