using CoachAndLaw.DataAccessLayer;
using CoachAndLaw.DTO;
using CoachAndLaw.Entity;
using CoachAndLaw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachAndLaw.Service
{
    public class ManteeInformationService : IMenteeInformationService
    {
        private IMenteeInformationDAL _menteeInformationDAL;
        public ManteeInformationService(IMenteeInformationDAL meenteInforamtionDAL)
        {
            _menteeInformationDAL = meenteInforamtionDAL;
        }
        public void CreateMentee(MenteeInformationModel menteeInformationModel)
        {
            //var menteeInformationDAL = new MenteeInformationDAL();
            var menteeInformation = new MenteeInformation
            {
                Address = menteeInformationModel.Address,
                CountryCode = menteeInformationModel.CountryCode,
                CVPath = menteeInformationModel.CVPath,
                Description = menteeInformationModel.Description,
                Email = menteeInformationModel.Email,
                FirstName = menteeInformationModel.FirstName,
                LastName = menteeInformationModel.LastName,
                MiddleName = menteeInformationModel.MiddleName,
                MobileNo = menteeInformationModel.MobileNo,
                Photo = menteeInformationModel.Photo,
                ServiceId = menteeInformationModel.ServiceId,
                TotalCost = menteeInformationModel.TotalCost,
                UniversityId = menteeInformationModel.UniversityId
            };

            _menteeInformationDAL.CreateMeneteeInformation(menteeInformation);
        }

        public List<MenteeInformation> GetMenteeInformation()
        {
            //var helper = new ResponseHelper();
            //var dal =  new MenteeInformationDAL();

            var menteeList = _menteeInformationDAL.GetMenteeInformation();
            
            return menteeList;
        }

        public MenteeInformationDTO GetMenteeInformationByEmail(string email)
        {
            //var menteeInformation = new MenteeInformation();
            //var dal = new MenteeInformationDAL();

            var mentee = _menteeInformationDAL.GetMenteeInformationByEmail(email);
            return mentee;
        }
    }
}
