using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CvStorage.Models
{
    public class Cv
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string FatherName { get; set; }

        public string MotherName { get; set; }
        public string Gender { get; set; }

        public string Religion { get; set; }
        public string MaritalStatus { get; set; }
        public string NationalId { get; set; }
        public string PrimaryMobile { get; set; }
        public string EmergencyContact { get; set; }
        public string BloodGroup { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string Objective { get; set; }
        public string PresentSalary { get; set; }
        public string ExpectedSalary { get; set; }
        public string SpecialSkills { get; set; }
        public string CareerSummary { get; set; }
        

    }
}
