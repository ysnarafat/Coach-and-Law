using CoachAndLaw.DataAccessLayer;
using CoachAndLaw.Entity;
using CoachAndLaw.Models;
using System;

namespace CoachAndLaw.Service
{
    public class AppUserService
    {
        public void Register(RegisterModel appUser)
        {
            var dal = new AppUserDAL();
            var newAppUser = new AppUser
            {
                Password = appUser.Password,
                SequirityQuestion = appUser.SequirityQuestion,
                UserName = appUser.UserName
            };
            dal.RegisterUser(newAppUser);
        }
    }
}
