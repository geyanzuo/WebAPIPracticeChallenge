using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;
using System.Configuration;

namespace WebAPI.Models
{
    public class DBAccessLayer
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public DataSet GetRecordbyid(int id)

        {

            SqlCommand com = new SqlCommand("SpgetDetailbyid", con);

            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@Sr_no", id);

            SqlDataAdapter da = new SqlDataAdapter(com);

            DataSet ds = new DataSet();

            da.Fill(ds);

            return ds;

        }

    }
}