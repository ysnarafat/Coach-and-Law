using CoachAndLaw.DataAccessLayer.Constants;
using CoachAndLaw.DTO;
using CoachAndLaw.Entity;
using CoachAndLaw.Foundation;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachAndLaw.DataAccessLayer
{
    public class MenteeInformationDAL : BaseDAL , IMenteeInformationDAL
    {
        ///private string connectionString;

        public MenteeInformationDAL(IOptions<ConnectionStringConfig> config) : base(config)
        {
           
        }


        /// <summary>
        ///  Returns MenteeInformationDTO
        /// </summary>
        /// <returns></returns>
        /// 
        public MenteeInformationDTO GetMenteeInformationByEmail(string email)
        {
            var result = new MenteeInformationDTO();
            var connectionString = GetConnectionString();
            var connection = new SqlConnection(connectionString);
            connection.Open();
            //var cmd = new SqlCommand("Select * from MenteeInformation where Email = '" + email+"';", connection);
            var spName = StoredProcedure.GetMenteeInfoByEmail;
            var cmd = new SqlCommand(spName, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Email", email));

            var reader = cmd.ExecuteReader();
            //if(reader != null)
            while (reader.Read())
            {
               
                var menteeInformationDTO = new MenteeInformationDTO
                {
                    MenteeId = Convert.ToInt16(reader[nameof(MenteeInformationDTO.MenteeId)].ToString()),
                    FirstName = reader[nameof(MenteeInformationDTO.FirstName)].ToString(),
                    LastName = reader[nameof(MenteeInformationDTO.LastName)].ToString(),
                    //Address = reader[nameof(MenteeInformation.Address)].ToString(),
                    CVPath = reader[nameof(MenteeInformationDTO.CVPath)].ToString(),
                    CountryCode = reader[nameof(MenteeInformationDTO.CountryCode)].ToString(),
                    Description = reader[nameof(MenteeInformationDTO.Description)].ToString(),
                    Email = reader[nameof(MenteeInformationDTO.Email)].ToString(),
                    MiddleName = reader[nameof(MenteeInformationDTO.MiddleName)].ToString(),
                    MobileNo = reader[nameof(MenteeInformationDTO.MobileNo)].ToString(),
                    Photo = reader[nameof(MenteeInformationDTO.Photo)].ToString(),
                    TotalCost = Convert.ToInt16(reader[nameof(MenteeInformationDTO.TotalCost)].ToString()),
                    ServiceName = reader[nameof(MenteeInformationDTO.ServiceName)].ToString(),
                    UniversityName = reader[nameof(MenteeInformationDTO.UniversityName)].ToString(),

                    //ServiceId = Convert.ToInt16(reader[nameof(MenteeInformation.ServiceId)].ToString()),
                    //UniversityId = Convert.ToInt16(reader[nameof(MenteeInformation.UniversityId)].ToString())
                };

                 result = menteeInformationDTO;
            }
                
            connection.Close();

            return result;

        }


        /// <summary>
        ///  Returns MenteeInformationDTO
        /// </summary>
        /// <returns></returns>
        public List<MenteeInformation> GetMenteeInformation()
        {
            var menteeInformationList = new List<MenteeInformation>();

            var connectionString = GetConnectionString();
            var connection = new SqlConnection(connectionString);
            connection.Open();
            var cmd = new SqlCommand("Select * from "+nameof(MenteeInformation)+"",connection);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var menteeInformation = new MenteeInformation
                {
                    MenteeId = Convert.ToInt16(reader[nameof(MenteeInformation.MenteeId)].ToString()),
                    FirstName = reader[nameof(MenteeInformation.FirstName)].ToString(),
                    LastName = reader[nameof(MenteeInformation.LastName)].ToString(),
                    Address = reader[nameof(MenteeInformation.Address)].ToString(),
                    CVPath = reader[nameof(MenteeInformation.CVPath)].ToString(),
                    CountryCode = reader[nameof(MenteeInformation.CountryCode)].ToString(),
                    Description = reader[nameof(MenteeInformation.Description)].ToString(),
                    Email = reader[nameof(MenteeInformation.Email)].ToString(),
                    MiddleName = reader[nameof(MenteeInformation.MiddleName)].ToString(),
                    MobileNo = reader[nameof(MenteeInformation.MobileNo)].ToString(),
                    Photo = reader[nameof(MenteeInformation.Photo)].ToString(),
                    ServiceId = Convert.ToInt16(reader[nameof(MenteeInformation.ServiceId)].ToString()),
                    TotalCost = Convert.ToInt16(reader[nameof(MenteeInformation.TotalCost)].ToString()),
                    UniversityId = Convert.ToInt16(reader[nameof(MenteeInformation.UniversityId)].ToString())
                    //CountryCode = reader["AppUserTypeId"].ToString(),
                    //CountryCode = reader["UserDetailsId"].ToString()
                };
                menteeInformationList.Add(menteeInformation);
            }
            connection.Close();

            return menteeInformationList;
        }

        // for inser change model value to entity in service and then transfer it to DAL
        public void CreateMeneteeInformation(MenteeInformation menteeInformation)
        {
            try
            {

                var connectionString = GetConnectionString();
                var connection = new SqlConnection(connectionString);
                connection.Open();
                var cmd = new SqlCommand("insert into "+nameof(MenteeInformation) +" values('" + menteeInformation.FirstName + "'," +
                    "'" + menteeInformation.MiddleName + "'," +
                    "'" + menteeInformation.LastName + "'," +
                    "'" + menteeInformation.Email + "'," +
                    "'" + menteeInformation.Description + "'," +
                    "'" + menteeInformation.MobileNo + "'," +
                    "'" + menteeInformation.Photo + "'," +
                    "'" + menteeInformation.CVPath + "'," +
                    "'" + menteeInformation.CountryCode + "'," +
                    "'" + menteeInformation.Address + "'," +
                    "'" + menteeInformation.TotalCost + "'," +
                    "'" + menteeInformation.UniversityId + "'," +
                    "'" + menteeInformation.ServiceId + "'" + ");", connection);


                var reader = cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}
