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
    public interface IMenteeInformationService
    {
        List<MenteeInformation> GetMenteeInformation();
        void CreateMentee(MenteeInformationModel menteeInformationModel);
        MenteeInformationDTO GetMenteeInformationByEmail(string email);
    }
}
