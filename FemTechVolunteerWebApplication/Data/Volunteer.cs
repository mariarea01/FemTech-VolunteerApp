using System.ComponentModel.DataAnnotations;

namespace FemTechVolunteerWebApplication.Data
{
    /// <summary>
    /// These are all the attributes for a Volunteer
    /// </summary>
    public class Volunteer
    {

        public int Id { get; set; }
        public string? VolunteerFirstName { get; set; }

        
        public string? VolunteerLastName { get; set; }

        [Display(Name = "Username")]
        public string? VolunteerUserName { get; set; }
        [Display(Name = "Password")]
        public string? VolunteerPassword { get; set; }

        public string? CentersPreferredToWork { get; set; }
        public string? SkillsInterests { get; set; }
        public string? AvailabilityTimes { get; set; }
        public string? VolunteerAddress { get; set; }
        public string? VolunteerPhoneNumber { get; set; }
        public string? VolunteerEmail { get; set; }
        public string? VolunteerEducationalBackground { get; set; }
        public string? VolunteerCurrentLicenses { get; set; }
        public string? VolunteerEmergencyName { get; set; }
        public string? VolunteerEmergencyPhone { get; set; }
        public string? VolunteerEmergencyEmail { get; set; }
        public string? VolunteerEmergencyAddress { get; set; }
        public bool? IsDriverLicense { get; set; } 
        public bool? IsSocialSecurity { get; set; } 
        public string? VolunteerApprovalStatus { get; set; }
    }
}
