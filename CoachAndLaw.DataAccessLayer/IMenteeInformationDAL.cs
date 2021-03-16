using CoachAndLaw.DTO;
using CoachAndLaw.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachAndLaw.DataAccessLayer
{
    public interface IMenteeInformationDAL
    {
        MenteeInformationDTO GetMenteeInformationByEmail(string email);
        List<MenteeInformation> GetMenteeInformation();

        void CreateMeneteeInformation(MenteeInformation menteeInformation);
    }
}
