using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachAndLaw.Entity
{
    public class MenteeInformation
    {

        public int MenteeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string MobileNo { get; set; }
        public string Photo { get; set; }
        public string CVPath { get; set; }
        public string CountryCode { get; set; }
        public string Address { get; set; }
        public int TotalCost { get; set; }
        public int UniversityId { get; set; }
        public int ServiceId { get; set; }

        // optional
        public string UniversityName { get; set; }
        public string ServiceName { get; set; }


    }
}
