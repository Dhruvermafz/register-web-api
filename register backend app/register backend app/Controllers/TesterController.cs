using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Data.SqlClient;
using System.Data;

using System.Configuration;
namespace register_backend_app.Controllers
{
    [RoutePrefix("api/Tester")]

    public class TesterController : ApiController
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand cmd = null;
        SqlDataAdapter da = null;

        [HttpPost]

        public string List<crud> insert ()
        {

            conn.Open();
            cmd = new SqlCommand("insert into crudCors values('" + id + "','" + name + "')", conn);
            int k = cmd.ExecuteNonQuery();
            if (k > 0)
            {
                return "success";
            }
            else
            {
                return "sorry";
            }
            conn.Close();
        }




        public class crud
        {
            public int id;
            public string name;

        }
    }
}