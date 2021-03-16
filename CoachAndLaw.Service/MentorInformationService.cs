using CoachAndLaw.DataAccessLayer;
using CoachAndLaw.DTO;
using CoachAndLaw.Entity;
using CoachAndLaw.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachAndLaw.Service
{
    public class MentorInformationService
    {
        public void CreateMentorInformation(MentorInformationModel mentorInformationModel)
        {
            var mentorInformationDAL = new MentorInformationDAL();
            var mentorInformation = new MentorInformation
            {
                Address = mentorInformationModel.Address,
                CountryCode = mentorInformationModel.CountryCode,
                CVPath = mentorInformationModel.CVPath,
                ProfileDescription = mentorInformationModel.ProfileDescription,
                Email = mentorInformationModel.Email,
                FirstName = mentorInformationModel.FirstName,
                LastName = mentorInformationModel.LastName,
                MiddleName = mentorInformationModel.MiddleName,
                MobileNo = mentorInformationModel.MobileNo,
                Photo = mentorInformationModel.Photo,
                ServiceId = mentorInformationModel.ServiceId,
                HiringPrice = mentorInformationModel.HiringPrice,
                TotalEarn = mentorInformationModel.TotalEarn,
                TotalWithdraw = mentorInformationModel.TotalWithdraw,
                IsAvailableToHire = mentorInformationModel.IsAvailabeToHire,
                NoOfHourFoMentee = mentorInformationModel.NoOfHourForMentee,
                Rating = mentorInformationModel.Rating,
                UniversityId = mentorInformationModel.UniversityId
            };

            mentorInformationDAL.CreateMenetorInformation(mentorInformation);
        }

        public MentorInformationDTO GetMentorInformationByEmail(string email)
        {
            var dal = new MentorInformationDAL();
            var mentor = dal.GetMentorInformationByEmail(email);

            return mentor;
        }
        public MentorInformationDTO GetNewMentor(MentorInformationModel model)
        {
            var dal = new MentorInformationDAL();
            var mentor = dal.GetMentorInformationByEmail(model.Email);

            return mentor;
        }

        public List<MentorInformation> GetMentorInformation()
        {

            var dictionary = new Dictionary<string, string>();

            var dal = new MentorInformationDAL();

            var list = dal.GetMentorInformation();
            try
            {
                //var list = dal.GetMentorInformation();

                //var json = Json.SerializeObject(list, Formatting.None);


                return list;
                //dictionary.Add("sucess", "true");
                //dictionary.Add("message", json);
                //dictionary.Add("status", "200");
                              
            }
            catch
            {
                dictionary.Add("sucess", "false");
                dictionary.Add("message", "Not found");
                dictionary.Add("status", "404");
            }

            return list;
        }
    }
}
