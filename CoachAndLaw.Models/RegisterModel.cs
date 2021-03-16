
using System.ComponentModel.DataAnnotations;

namespace CoachAndLaw.Models
{
    public class RegisterModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public string SequirityQuestion { get; set; }

    }
}
