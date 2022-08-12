using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FemTechVolunteerWebApplication.Data.Migrations
{
    public partial class VolunteersTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Volunteers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VolunteerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VolunteerLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VolunteerUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VolunteerPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CentersPreferredToWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkillsInterests = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvailabilityTimes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VolunteerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VolunteerPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VolunteerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VolunteerEducationalBackground = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VolunteerCurrentLicenses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VolunteerEmergencyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VolunteerEmergencyPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VolunteerEmergencyEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VolunteerEmergencyAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDriverLicense = table.Column<bool>(type: "bit", nullable: true),
                    IsSocialSecurity = table.Column<bool>(type: "bit", nullable: true),
                    VolunteerApprovalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Volunteers");
        }
    }
}
