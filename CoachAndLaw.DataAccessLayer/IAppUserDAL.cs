using CoachAndLaw.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachAndLaw.DataAccessLayer
{
    public interface IAppUserDAL
    {
        List<AppUser> GetUser();

        void RegisterUser(AppUser appUser);
    }
}
