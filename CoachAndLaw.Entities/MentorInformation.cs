using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachAndLaw.Entity
{
    public class MentorInformation
    {
        public int MentorId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ProfileDescription { get; set; }
        public string MobileNo { get; set; }
        public string Photo { get; set; }
        public string CVPath { get; set; }
        public string CountryCode { get; set; }
        public string Address { get; set; }
        public float HiringPrice { get; set; }
        public float Rating { get; set; }
        public int IsAvailableToHire { get; set; }
        public int NoOfHourFoMentee { get; set; }
        public int TotalEarn { get; set; }
        public int TotalWithdraw { get; set; }
        public int UniversityId { get; set; }
        public int ServiceId { get; set; }
    }
}
