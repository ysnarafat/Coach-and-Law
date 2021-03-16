using CoachAndLaw.DataAccessLayer.Constants;
using CoachAndLaw.DTO;
using CoachAndLaw.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachAndLaw.DataAccessLayer
{
    public class MentorInformationDAL
    {
        private string connectionString;
        public MentorInformationDAL()
        {
            
        }

        public List<MentorInformation> GetMentorInformation()
        {
            var mentorInformationList = new List<MentorInformation>();

            var connection = new SqlConnection(connectionString);
            connection.Open();
            var cmd = new SqlCommand("Select * from " + nameof(MentorInformation) + "",connection);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var mentorInformation = new MentorInformation
                {
                    MentorId = Convert.ToInt16(reader[nameof(MentorInformation.MentorId)].ToString()),
                    FirstName = reader[nameof(MentorInformation.FirstName)].ToString(),
                    LastName = reader[nameof(MentorInformation.LastName)].ToString(),
                    Address = reader[nameof(MentorInformation.Address)].ToString(),
                    CVPath = reader[nameof(MentorInformation.CVPath)].ToString(),
                    CountryCode = reader[nameof(MentorInformation.CountryCode)].ToString(),
                    ProfileDescription = reader[nameof(MentorInformation.ProfileDescription)].ToString(),
                    Email = reader[nameof(MentorInformation.Email)].ToString(),
                    MiddleName = reader[nameof(MentorInformation.MiddleName)].ToString(),
                    MobileNo = reader[nameof(MentorInformation.MobileNo)].ToString(),
                    Photo = reader[nameof(MentorInformation.Photo)].ToString(),
                    ServiceId = Convert.ToInt16(reader[nameof(MentorInformation.ServiceId)].ToString()),
                    HiringPrice = Convert.ToSingle(reader[nameof(MentorInformation.HiringPrice)].ToString()),
                    Rating = Convert.ToSingle(reader[nameof(MentorInformation.Rating)].ToString()),
                    IsAvailableToHire = Convert.ToInt16(reader[nameof(MentorInformation.IsAvailableToHire)].ToString()),
                    NoOfHourFoMentee = Convert.ToInt16(reader[nameof(MentorInformation.NoOfHourFoMentee)].ToString()),
                    TotalEarn = Convert.ToInt16(reader[nameof(MentorInformation.TotalEarn)].ToString()),
                    TotalWithdraw = Convert.ToInt16(reader[nameof(MentorInformation.TotalWithdraw)].ToString()),
                    UniversityId = Convert.ToInt16(reader[nameof(MentorInformation.UniversityId)].ToString())                    
                    //CountryCode = reader["AppUserTypeId"].ToString(),
                    //CountryCode = reader["UserDetailsId"].ToString()
                };
                mentorInformationList.Add(mentorInformation);
            }
            connection.Close();

            return mentorInformationList;
        }

        public MentorInformationDTO GetMentorInformationByEmail(string email)
        {
            var result = new MentorInformationDTO();

            var connection = new SqlConnection(connectionString);
            connection.Open();
            var spName = StoredProcedure.GetMentorInfoByEmail;
            var cmd = new SqlCommand(spName, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Email", email));

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var mentorInformation = new MentorInformationDTO
                {
                    MentorId = Convert.ToInt16(reader[nameof(MentorInformationDTO.MentorId)].ToString()),
                    FirstName = reader[nameof(MentorInformationDTO.FirstName)].ToString(),
                    LastName = reader[nameof(MentorInformationDTO.LastName)].ToString(),
                    Address = reader[nameof(MentorInformationDTO.Address)].ToString(),
                    CVPath = reader[nameof(MentorInformationDTO.CVPath)].ToString(),
                    CountryCode = reader[nameof(MentorInformationDTO.CountryCode)].ToString(),
                    ProfileDescription = reader[nameof(MentorInformationDTO.ProfileDescription)].ToString(),
                    Email = reader[nameof(MentorInformationDTO.Email)].ToString(),
                    MiddleName = reader[nameof(MentorInformationDTO.MiddleName)].ToString(),
                    MobileNo = reader[nameof(MentorInformationDTO.MobileNo)].ToString(),
                    Photo = reader[nameof(MentorInformationDTO.Photo)].ToString(),
                    HiringPrice = Convert.ToSingle(reader[nameof(MentorInformationDTO.HiringPrice)].ToString()),
                    Rating = Convert.ToSingle(reader[nameof(MentorInformationDTO.Rating)].ToString()),
                    IsAvailableToHire = Convert.ToInt16(reader[nameof(MentorInformationDTO.IsAvailableToHire)].ToString()),
                    NoOfHourFoMentee = Convert.ToInt16(reader[nameof(MentorInformationDTO.NoOfHourFoMentee)].ToString()),
                    TotalEarn = Convert.ToInt16(reader[nameof(MentorInformationDTO.TotalEarn)].ToString()),
                    TotalWithdraw = Convert.ToInt16(reader[nameof(MentorInformationDTO.TotalWithdraw)].ToString()),
                    UniversityName = reader[nameof(MentorInformationDTO.UniversityName)].ToString(),
                    ServiceName = reader[nameof(MentorInformationDTO.ServiceName)].ToString()
                    //CountryCode = reader["AppUserTypeId"].ToString(),
                    //CountryCode = reader["UserDetailsId"].ToString()
                };
                result = mentorInformation;
            }
            connection.Close();

            return result;
        }

        public void CreateMenetorInformation(MentorInformation menteeInformation)
        {
            var mentorInformation = new MentorInformation();
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();



                var cmd = new SqlCommand("insert into " + nameof(MentorInformation) + " values('" + menteeInformation.FirstName + "'," +
                    "'" + menteeInformation.MiddleName + "'," +
                    "'" + menteeInformation.LastName + "'," +
                    "'" + menteeInformation.Email + "'," +
                    "'" + menteeInformation.ProfileDescription + "'," +
                    "'" + menteeInformation.MobileNo + "'," +
                    "'" + menteeInformation.Photo + "'," +
                    "'" + menteeInformation.CVPath + "'," +
                    "'" + menteeInformation.CountryCode + "'," +
                    "'" + menteeInformation.Address + "'," +
                    "'" + menteeInformation.HiringPrice + "'," +
                    "'" + menteeInformation.Rating + "'," +
                    "'" + menteeInformation.IsAvailableToHire + "'," +
                    "'" + menteeInformation.NoOfHourFoMentee + "'," +
                    "'" + menteeInformation.TotalEarn + "'," +
                    "'" + menteeInformation.TotalWithdraw + "'," +
                    "'" + menteeInformation.UniversityId + "'," +
                    "'" + menteeInformation.ServiceId + "'" + ");", connection);






                //var cmd = new SqlCommand("insert into " + nameof(MentorInformation) + " values("+
                //    "@FirstName," +
                //    "@MiddleName," +
                //    "@LastName," +
                //    "@Email," +
                //    "@ProfileDescription," +
                //    "@MobileNo," +
                //    "@Photo," +
                //    "@CVPath," +
                //    "@CountryCode," +
                //    "@Address," +
                //    "@HiringPrice," +
                //    "@Rating," +
                //    "@IsAvailabeToHire," +
                //    "@NoOfHourForMentee," +
                //    "@TotalEarn," +
                //    "@TotalWithdraw," +
                //    "@UniversityId," +
                //    "@ServiceId" + ");", connection);

                ////cmd.Parameters.Add("@FirstName", System.Data.SqlDbType.NVarChar) = MentorInformation.FirstName;
                //cmd.Parameters.AddWithValue("@FirstName", mentorInformation.FirstName);
                //cmd.Parameters.AddWithValue("@MiddleName", mentorInformation.MiddleName);
                //cmd.Parameters.AddWithValue("@LastName", mentorInformation.LastName);
                //cmd.Parameters.AddWithValue("@Email", mentorInformation.Email);
                //cmd.Parameters.AddWithValue("@ProfileDescription", mentorInformation.ProfileDescription);
                //cmd.Parameters.AddWithValue("@MobileNo", mentorInformation.MobileNo);
                //cmd.Parameters.AddWithValue("@Photo", mentorInformation.Photo);
                //cmd.Parameters.AddWithValue("@CVPath", mentorInformation.CVPath);
                //cmd.Parameters.AddWithValue("@CountryCode", mentorInformation.CountryCode);
                //cmd.Parameters.AddWithValue("@Address", mentorInformation.Address);
                //cmd.Parameters.AddWithValue("@HiringPrice", mentorInformation.HiringPrice);
                //cmd.Parameters.AddWithValue("@Rating", mentorInformation.Rating);
                //cmd.Parameters.AddWithValue("@IsAvailabeToHire", mentorInformation.IsAvailabeToHire);
                //cmd.Parameters.AddWithValue("@NoOfHourForMentee", mentorInformation.NoOfHourForMentee);
                //cmd.Parameters.AddWithValue("@TotalEarn", mentorInformation.TotalEarn);
                //cmd.Parameters.AddWithValue("@TotalWithdraw", mentorInformation.TotalWithdraw);
                //cmd.Parameters.AddWithValue("@UniversityId", mentorInformation.UniversityId);
                //cmd.Parameters.AddWithValue("@ServiceId", mentorInformation.ServiceId);


                //"'" + menteeInformation.IsAvailabeToHire + "'," +
                //"'" + menteeInformation.NoOfHourForMentee + "'," +
                //"'" + menteeInformation.TotalEarn + "'," +
                //"'" + menteeInformation.TotalWithdraw + "'," +
                //"'" + menteeInformation.UniversityId + "'," +
                //"'" + menteeInformation.ServiceId + "'" + ";", connection);


                var reader = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
