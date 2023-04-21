using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using register_backend_app.Models;

namespace register_backend_app.Controllers
{
    [RoutePrefix("api/Crud")]
    public class CrudController : ApiController
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand cmd = null;
        SqlDataAdapter da = null;

        [HttpPost]
        [Route("insert")]

        public string insert(Crud crud)
        {
            string msg = string.Empty;

            try
            {
                cmd = new SqlCommand("usp_Insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", crud.Id);
                cmd.Parameters.AddWithValue("@Name", crud.Name);
                cmd.Parameters.AddWithValue("@RollNo", crud.RollNo);
                cmd.Parameters.AddWithValue("@Marks", crud.Marks);
      


                conn.Open();
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    msg = "Data Inserted";
                }
                else
                {
                    msg = "An Error Occured";
                }
            }
            catch (Exception ex)
            {
                msg = "An Exception Occured";
            }
            return msg;
        }

        [HttpDelete]
        [Route("delete")]

        public string delete(Crud crud)
        {
            string msg = string.Empty;

            try
            {
                cmd = new SqlCommand("usp_Delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", crud.Id);
                cmd.Parameters.AddWithValue("@Name", crud.Name);
                cmd.Parameters.AddWithValue("@RollNo", crud.RollNo);
                cmd.Parameters.AddWithValue("@Marks", crud.Marks);




                conn.Open();
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    msg = "Data Deleted";
                }
                else
                {
                    msg = "An Error Occured";
                }
            }
            catch (Exception ex)
            {
                msg = "An Exception Occured";
            }
            return msg;
        }

        [HttpPut]
        [Route("update")]

        public string update(Crud crud)
        {
            string msg = string.Empty;

            try
            {
                cmd = new SqlCommand("usp_Update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", crud.Id);
                cmd.Parameters.AddWithValue("@Name", crud.Name);
                cmd.Parameters.AddWithValue("@RollNo", crud.RollNo);
                cmd.Parameters.AddWithValue("@Marks", crud.Marks);

                conn.Open();
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    msg = "Data updated";
                }
                else
                {
                    msg = "An Error Occured";
                }
            }
            catch (Exception ex)
            {
                msg = "An Exception Occured";
            }
            return msg;
        }

        [HttpGet]
        [Route("get")]

        public List<record> get( )
        {
            conn.Open();
            cmd = new SqlCommand("select *from StuDetails ", conn);
           SqlDataReader dr= cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            List<record> lst = new List<record>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                record obj = new record();
               obj.id= Convert.ToInt32(dt.Rows[i]["Id"].ToString());
                obj.name = dt.Rows[i]["Name"].ToString();
                obj.roll = Convert.ToSingle(dt.Rows[i]["RollNo"].ToString());
                obj.marks = dt.Rows[i]["Marks"].ToString();
                lst.Add(obj);
            }
            conn.Close();
            return lst;
        }



    }

 public class record
    {
        public int id;
        public string name;
        public float roll;
        public string marks;
    }
}
