using mynamespace;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace mvc_demo.Data
{
    public class Employeedata
    {
        public List<Mytable> Dbconnect()
        {

            string connectionString = ConfigurationManager.ConnectionStrings["connectinstringName"].ToString();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

           
            //string cmd1 = "USE master";
            string cmd2 = "select Name,Age from Mytable";
            //string cmd3 = "Insert into Mytable values ( 'Akila' , '23')";

           // SqlCommand sqlcommand1 = new SqlCommand(cmd1, sqlConnection);
            SqlCommand sqlcommand2 = new SqlCommand(cmd2, sqlConnection);
            //SqlCommand sqlcommand3 = new SqlCommand(cmd3, sqlConnection);

            SqlDataReader sqlreader = sqlcommand2.ExecuteReader();

            List<Mytable> objproperty = new List<Mytable>();
         

            while (sqlreader.Read())
            {
                int ageint=0;
                Int32.TryParse(sqlreader["Age"].ToString(),out ageint);
                objproperty.Add(new Mytable
                {

                    Name = sqlreader["Name"].ToString(),
                   // Age = (object) sqlreader["Age"]
                   
                    Age=ageint     


                });
                 

            }
            sqlConnection.Close();
            return objproperty;
        }
    }
}