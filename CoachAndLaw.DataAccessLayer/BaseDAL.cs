using CoachAndLaw.Foundation;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachAndLaw.DataAccessLayer
{
    public class BaseDAL
    {
        private readonly ConnectionStringConfig _connectionStringConfig;

          
        public BaseDAL(IOptions<ConnectionStringConfig> configAccessor)
        {
            _connectionStringConfig = configAccessor.Value;  
            
            // Your connection string value is here:
            // _connectionStringConfig.AppDbConnection;
        }

        protected string GetConnectionString()
        {
            return _connectionStringConfig.DefaultConnection;
        }
    }
}
