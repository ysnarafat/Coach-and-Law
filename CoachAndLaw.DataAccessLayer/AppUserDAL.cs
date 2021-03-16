using CoachAndLaw.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachAndLaw.DataAccessLayer
{
    public class AppUserDAL : IAppUserDAL
    {
        private string connectionString;
        public AppUserDAL()
        {
            connectionString = "Server=. ;Database = CoachAndLawDb ; User Id = demo; Password = 123456;";
        }

        public List<AppUser> GetUser()
        {
            var appUserList = new List<AppUser>();

            var connection = new SqlConnection(connectionString);
            connection.Open();
            var cmd = new SqlCommand("Select * from AppUsers");
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var appUser = new AppUser
                {
                    AppUserId = Convert.ToInt16(reader["AppUserId"].ToString()),
                    UserName = reader["UserName"].ToString(),
                    Password = reader["UserPassword"].ToString(),
                    SequirityQuestion = reader["SecurityQuestion"].ToString(),
                    //CountryCode = reader["AppUserTypeId"].ToString(),
                    //CountryCode = reader["UserDetailsId"].ToString()
                };
                appUserList.Add(appUser);
            }
            connection.Close();

            return appUserList;
        }

        public void RegisterUser(AppUser appUser)
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            var cmd = new SqlCommand("insert into AppUsers values('"+appUser.UserName+"','"+appUser.Password+"','"+appUser.SequirityQuestion+"',1,11);",connection);
            

            var reader = cmd.ExecuteNonQuery();
            Console.WriteLine(reader);

        }
    }
}
