using System.ComponentModel.DataAnnotations;

namespace FemTechVolunteerWebApplication.Models
{
    public class VolunteersModel
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string? VolunteerFirstName { get; set; }
        [Display(Name = "Last Name")]
        public string? VolunteerLastName { get; set; }

        [Display(Name = "Volunteer Opportunity")]
        public string? CentersPreferredToWork { get; set; }

        [Display(Name = "Approval Status")]
        public string? VolunteerApprovalStatus { get; set; }

        //I only want the above details to be listed in the Manage Volunteer table
        //public string? VolunteerUserName { get; set; }
        //public string? VolunteerPassword { get; set; }
        //public string? SkillsInterests { get; set; }
        //public string? AvailabilityTimes { get; set; }
        //public string? VolunteerAddress { get; set; }
        //public string? VolunteerPhoneNumber { get; set; }
        //public string? VolunteerEmail { get; set; }
        //public string? VolunteerEducationalBackground { get; set; }
        //public string? VolunteerCurrentLicenses { get; set; }
        //public string? VolunteerEmergencyName { get; set; }
        //public string? VolunteerEmergencyPhone { get; set; }
        //public string? VolunteerEmergencyEmail { get; set; }
        //public string? VolunteerEmergencyAddress { get; set; }
        //public bool? IsDriverLicense { get; set; }
        //public bool? IsSocialSecurity { get; set; }
    }
}
