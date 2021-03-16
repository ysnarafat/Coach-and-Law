using CoachAndLaw.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CoachAndLaw.DataAccessLayer
{
    public class UniversityDAL 
    {
        private string connectionString;
        public UniversityDAL()
        {
       
        }

        public List<University> GetUniversity()
        {
            var universityList = new List<University>();

            var connection = new SqlConnection(connectionString);
            connection.Open();
            var cmd = new SqlCommand("Select * from Universities;",connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var university = new University
                {
                    UniversityId = Convert.ToInt16(reader["UniversityId"].ToString()),
                    CountryCode = reader["CountryCode"].ToString(),
                    UniversityName = reader["UniversityName"].ToString()
                };
                universityList.Add(university);
            }
            connection.Close();

            return universityList;
        }
    }
}
