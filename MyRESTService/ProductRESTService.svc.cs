using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace MyRESTService
{
    public class ProductRESTService : IProductRESTService
    {
        public List<Product> GetProductList(string name)
        {
            return Products.Instance.ProductList;
        }

        public string PostSampleMethod(UserDetails userInfo)
        {
            string Message = "Data Inserted Succesfully...!";
            string abc = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(abc);
            //con.Open();
            //SqlCommand cmd = new SqlCommand("insert into RegistrationTable(UserName,Password,Country,Email) values(@UserName,@Password,@Country,@Email)", con);
            //cmd.Parameters.AddWithValue("@UserName", userInfo.UserName);
            //cmd.Parameters.AddWithValue("@Password", userInfo.Password);
            //cmd.Parameters.AddWithValue("@Country", userInfo.Country);
            //cmd.Parameters.AddWithValue("@Email", userInfo.Email);

            //int result = cmd.ExecuteNonQuery();
            //if (result == 1)
            //{
            //    Message = userInfo.UserName + " Details inserted successfully";
            //}
            //else
            //{
            //    Message = userInfo.UserName + " Details not inserted successfully";
            //}
            //con.Close();

            return Message;
        }       
    }
}


