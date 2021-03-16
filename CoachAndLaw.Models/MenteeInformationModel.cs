using System;
using System.ComponentModel.DataAnnotations;

namespace CoachAndLaw.Models
{
    public class MenteeInformationModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public string Description { get; set; }
        [Required]
        public string MobileNo { get; set; }
        public string Photo { get; set; }
        public string CVPath { get; set; }
        [Required]
        public string CountryCode { get; set; }
        [Required]
        public string Address { get; set; }
        public int TotalCost { get; set; }
        [Required]
        public int UniversityId { get; set; }
        [Required]
        public int ServiceId { get; set; }

    }
}
