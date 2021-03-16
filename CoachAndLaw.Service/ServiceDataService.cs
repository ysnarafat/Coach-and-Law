using CoachAndLaw.DataAccessLayer;
using CoachAndLaw.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachAndLaw.Service
{
    public class ServiceDataService
    {
        public List<ServiceDTO> GetServices()
        {
            var dal = new ServiceDAL();
            var result = dal.GetServices();

            return result;
        }
    }
}
