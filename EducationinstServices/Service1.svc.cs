﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EducationinstServices
{// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public EducationalInfo GetEducationalDetails(string region)
        {
            EducationalInfo infor = null;
            SqlConnection connection = new SqlConnection("Data Source= ASPLAPR406; Initial Catalog=TrainingDb; Integrated Security= True");
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT [BtechCollege],[MedicalCollege],[MbaCollege] FROM [TrainingDb] where region=@region", connection);
            command.Parameters.AddWithValue("@region", region);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                infor = new EducationalInfo();
                infor.BtechCollege = reader.GetInt32(0);
                infor.MedicalCollege = reader.GetInt32(1);
                infor.MbaCollege = reader.GetInt32(2);
            }
            connection.Close();
            return infor;
        }
    }
}
