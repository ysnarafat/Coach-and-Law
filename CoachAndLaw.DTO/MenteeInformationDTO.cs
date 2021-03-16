using System;

namespace CoachAndLaw.DTO
{
    public class MenteeInformationDTO
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

        public string UniversityName { get; set; }
        public string ServiceName { get; set; }

        // optional
        //public int UniversityId { get; set; }
        //public int ServiceId { get; set; }

    }
}
