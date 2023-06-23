using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademyFP.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Branch_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SupervisorName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DeletionStatus = table.Column<bool>(type: "bit", nullable: false),
                    SupervisorLandlineNumber = table.Column<int>(type: "int", nullable: false),
                    SupervisorPhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Branch_ID);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Course_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CourseDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CourseCost = table.Column<int>(type: "int", nullable: false),
                    DeletionStatus = table.Column<bool>(type: "bit", nullable: false),
                    CourseDurationInHours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Course_ID);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Group_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeletionStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Group_ID);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Language_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DeletionStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Language_ID);
                });

            migrationBuilder.CreateTable(
                name: "Trainees",
                columns: table => new
                {
                    TraineeNational_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicFullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EnglishFullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Religion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstPhoneNumber = table.Column<int>(type: "int", nullable: false),
                    SecondPhoneNumber = table.Column<int>(type: "int", nullable: false),
                    LandlineNumber = table.Column<int>(type: "int", nullable: false),
                    Recommender = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AcademicQualification = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    QualificationObtainingYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AcademicYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MilitaryStatus = table.Column<int>(type: "int", nullable: false),
                    PersonalPhoto = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NationalIdCardCopy = table.Column<int>(type: "int", nullable: false),
                    AcademicQualifictionCopy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ActivityStatus = table.Column<bool>(type: "bit", nullable: false),
                    DeletionStatus = table.Column<bool>(type: "bit", nullable: false),
                    Branch_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainees", x => x.TraineeNational_ID);
                    table.ForeignKey(
                        name: "FK_Trainees_Branches_Branch_ID",
                        column: x => x.Branch_ID,
                        principalTable: "Branches",
                        principalColumn: "Branch_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Subject_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ContainingCourseName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DeletionStatus = table.Column<bool>(type: "bit", nullable: false),
                    Course_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Subject_ID);
                    table.ForeignKey(
                        name: "FK_Subjects_Courses_Course_ID",
                        column: x => x.Course_ID,
                        principalTable: "Courses",
                        principalColumn: "Course_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    ActivityStatus = table.Column<bool>(type: "bit", nullable: false),
                    DeletionStatus = table.Column<bool>(type: "bit", nullable: false),
                    Group_ID = table.Column<int>(type: "int", nullable: false),
                    Language_ID = table.Column<int>(type: "int", nullable: false),
                    Branch_ID = table.Column<int>(type: "int", nullable: false),
                    IsSupervisor = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Username);
                    table.ForeignKey(
                        name: "FK_Users_Branches_Branch_ID",
                        column: x => x.Branch_ID,
                        principalTable: "Branches",
                        principalColumn: "Branch_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Groups_Group_ID",
                        column: x => x.Group_ID,
                        principalTable: "Groups",
                        principalColumn: "Group_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Languages_Language_ID",
                        column: x => x.Language_ID,
                        principalTable: "Languages",
                        principalColumn: "Language_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TraineeFinancialTranscations",
                columns: table => new
                {
                    Transaction_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceivedMoneyAmount = table.Column<bool>(type: "bit", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Course_ID = table.Column<int>(type: "int", nullable: false),
                    TraineeNational_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraineeFinancialTranscations", x => x.Transaction_id);
                    table.ForeignKey(
                        name: "FK_TraineeFinancialTranscations_Courses_Course_ID",
                        column: x => x.Course_ID,
                        principalTable: "Courses",
                        principalColumn: "Course_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TraineeFinancialTranscations_Trainees_TraineeNational_id",
                        column: x => x.TraineeNational_id,
                        principalTable: "Trainees",
                        principalColumn: "TraineeNational_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TraineeHasCourses",
                columns: table => new
                {
                    TraineeNational_ID = table.Column<int>(type: "int", nullable: false),
                    Course_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraineeHasCourses", x => new { x.TraineeNational_ID, x.Course_ID });
                    table.ForeignKey(
                        name: "FK_TraineeHasCourses_Courses_Course_ID",
                        column: x => x.Course_ID,
                        principalTable: "Courses",
                        principalColumn: "Course_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TraineeHasCourses_Trainees_TraineeNational_ID",
                        column: x => x.TraineeNational_ID,
                        principalTable: "Trainees",
                        principalColumn: "TraineeNational_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_Course_ID",
                table: "Subjects",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TraineeFinancialTranscations_Course_ID",
                table: "TraineeFinancialTranscations",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TraineeFinancialTranscations_TraineeNational_id",
                table: "TraineeFinancialTranscations",
                column: "TraineeNational_id");

            migrationBuilder.CreateIndex(
                name: "IX_TraineeHasCourses_Course_ID",
                table: "TraineeHasCourses",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_Branch_ID",
                table: "Trainees",
                column: "Branch_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Branch_ID",
                table: "Users",
                column: "Branch_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Group_ID",
                table: "Users",
                column: "Group_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Language_ID",
                table: "Users",
                column: "Language_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "TraineeFinancialTranscations");

            migrationBuilder.DropTable(
                name: "TraineeHasCourses");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Trainees");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Branches");
        }
    }
}
