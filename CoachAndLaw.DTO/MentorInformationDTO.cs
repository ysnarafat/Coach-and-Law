using System;
using System.Collections.Generic;
using System.Text;

namespace CoachAndLaw.DTO
{
    public class MentorInformationDTO
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
        public string UniversityName { get; set; }
        public string ServiceName { get; set; }
    }
}
