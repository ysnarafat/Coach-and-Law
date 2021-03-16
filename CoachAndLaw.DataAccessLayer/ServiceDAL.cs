using CoachAndLaw.DataAccessLayer.Constants;
using CoachAndLaw.DTO;
using CoachAndLaw.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachAndLaw.DataAccessLayer
{
    public class ServiceDAL
    {
        private readonly string connectionString;
        public ServiceDAL()
        {
           
        }

        public List<ServiceDTO> GetServices()
        {
            var services = new List<ServiceDTO>();

            var connection = new SqlConnection(connectionString);
            connection.Open();
            //var cmd = new SqlCommand("Select * from Services;" + ";", connection);
            var spName = StoredProcedure.GetServices;
            var cmd = new SqlCommand( spName, connection);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var serviceDTO = new ServiceDTO
                {
                    ServiceId = Convert.ToInt16(reader[nameof(ServiceDTO.ServiceId)].ToString()),
                    ServiceName = reader[nameof(ServiceDTO.ServiceName)].ToString(),
                    ServiceTypeName = reader[nameof(ServiceDTO.ServiceTypeName)].ToString()
                };
                services.Add(serviceDTO);
            }
            connection.Close();

            return services;
        }

    }
}
