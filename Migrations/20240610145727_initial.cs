using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopJobs.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empdetails",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeCompany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeePhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeePassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empdetails", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    JobId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    JobDesigntion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RolesandResponsibility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skillsneeded = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobSalary = table.Column<int>(type: "int", nullable: false),
                    Eligibility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    JobCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.JobId);
                });

            migrationBuilder.CreateTable(
                name: "Jsdetails",
                columns: table => new
                {
                    JsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JsCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JsState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JsCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JsGender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JsPhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JsEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JsPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jsdetails", x => x.JsId);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Emailid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Emailid);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    MembershipType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfPayment = table.Column<DateOnly>(type: "date", nullable: false),
                    Endofmembership = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                });

            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    ResumeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JsId = table.Column<int>(type: "int", nullable: false),
                    Skills = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tenpercentage = table.Column<int>(type: "int", nullable: false),
                    tenyear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    twelvepercentage = table.Column<int>(type: "int", nullable: false),
                    twelveyear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ugpercentage = table.Column<int>(type: "int", nullable: false),
                    ugyear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pgpercentage = table.Column<int>(type: "int", nullable: false),
                    pgyear = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.ResumeId);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empdetails");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Jsdetails");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Resumes");

            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
