using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoachAndLaw.Model
{
    public class MentorInformationModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }
        public string ProfileDescription { get; set; }

        [Required]
        public string MobileNo { get; set; }
        public string Photo { get; set; }
        public string CVPath { get; set; }
        public string CountryCode { get; set; }

        [Required]
        public string Address { get; set; }
        public float HiringPrice { get; set; }
        public float Rating { get; set; }
        public int IsAvailabeToHire { get; set; }
        public int NoOfHourForMentee { get; set; }
        public int TotalEarn { get; set; }
        public int TotalWithdraw { get; set; }

        [Required]
        public int UniversityId { get; set; }

        [Required]
        public int ServiceId { get; set; }
    }
}
