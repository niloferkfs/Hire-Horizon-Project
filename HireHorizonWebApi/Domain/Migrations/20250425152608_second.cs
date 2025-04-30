using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_JobPosts_JobPostId",
                table: "JobApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_JobSeekers_ApplicantId",
                table: "JobApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_Resumes_ResumeId",
                table: "JobApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobInterviews_CompanyUsers_ScheduledById",
                table: "JobInterviews");

            migrationBuilder.DropForeignKey(
                name: "FK_JobInterviews_JobApplications_JobApplicationId",
                table: "JobInterviews");

            migrationBuilder.DropForeignKey(
                name: "FK_JobInterviews_JobSeekers_IntervieweeId",
                table: "JobInterviews");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_CompanyUsers_PostedByNavigationId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Locations_JobLocationNavigationId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobProviderCompanies_Locations_LocationNavigationId",
                table: "JobProviderCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_JobPosts_JobPostNavigationId",
                table: "Skills");

            migrationBuilder.DropTable(
                name: "AuthUsers");

            migrationBuilder.DropIndex(
                name: "IX_Skills_JobPostNavigationId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_JobLocationNavigationId",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobInterviews_IntervieweeId",
                table: "JobInterviews");

            migrationBuilder.DropColumn(
                name: "JobPost",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "JobPostNavigationId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "JobSeekerProfileId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Industry",
                table: "JobProviderCompanies");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "Industry",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "JobLocationNavigationId",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "PostedDate",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "DateScheduled",
                table: "JobInterviews");

            migrationBuilder.DropColumn(
                name: "IntervieweeId",
                table: "JobInterviews");

            migrationBuilder.RenameColumn(
                name: "LocationNavigationId",
                table: "JobProviderCompanies",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "JobProviderCompanies",
                newName: "IndustryId");

            migrationBuilder.RenameIndex(
                name: "IX_JobProviderCompanies_LocationNavigationId",
                table: "JobProviderCompanies",
                newName: "IX_JobProviderCompanies_LocationId");

            migrationBuilder.RenameColumn(
                name: "PostedByNavigationId",
                table: "JobPosts",
                newName: "LocationNavigationId");

            migrationBuilder.RenameIndex(
                name: "IX_JobPosts_PostedByNavigationId",
                table: "JobPosts",
                newName: "IX_JobPosts_LocationNavigationId");

            migrationBuilder.RenameColumn(
                name: "ScheduledById",
                table: "JobInterviews",
                newName: "CompanyId");

            migrationBuilder.RenameColumn(
                name: "JobApplicationId",
                table: "JobInterviews",
                newName: "interviewee");

            migrationBuilder.RenameIndex(
                name: "IX_JobInterviews_ScheduledById",
                table: "JobInterviews",
                newName: "IX_JobInterviews_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_JobInterviews_JobApplicationId",
                table: "JobInterviews",
                newName: "IX_JobInterviews_interviewee");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "JobApplications",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "DateSubmitted",
                table: "JobApplications",
                newName: "Datesubmitted");

            migrationBuilder.RenameColumn(
                name: "ResumeId",
                table: "JobApplications",
                newName: "Resume_id");

            migrationBuilder.RenameColumn(
                name: "JobPostId",
                table: "JobApplications",
                newName: "JobPost_id");

            migrationBuilder.RenameColumn(
                name: "ApplicantId",
                table: "JobApplications",
                newName: "Applicant");

            migrationBuilder.RenameIndex(
                name: "IX_JobApplications_ResumeId",
                table: "JobApplications",
                newName: "IX_JobApplications_Resume_id");

            migrationBuilder.RenameIndex(
                name: "IX_JobApplications_JobPostId",
                table: "JobApplications",
                newName: "IX_JobApplications_JobPost_id");

            migrationBuilder.RenameIndex(
                name: "IX_JobApplications_ApplicantId",
                table: "JobApplications",
                newName: "IX_JobApplications_Applicant");

            migrationBuilder.AlterColumn<Guid>(
                name: "PostedBy",
                table: "JobPosts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "JobLocation",
                table: "JobPosts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "Category",
                table: "JobPosts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "JobPosts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IndustryId",
                table: "JobPosts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationId",
                table: "JobInterviews",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "JobInterviews",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SheduledBy",
                table: "JobInterviews",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "CompanyUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "CompanyUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "CompanyUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "CompanyUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Roles",
                table: "CompanyUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "CompanyUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AuthUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthUser", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobProviderCompanies_IndustryId",
                table: "JobProviderCompanies",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_Category",
                table: "JobPosts",
                column: "Category");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_CompanyId",
                table: "JobPosts",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_IndustryId",
                table: "JobPosts",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_PostedBy",
                table: "JobPosts",
                column: "PostedBy");

            migrationBuilder.CreateIndex(
                name: "IX_JobInterviews_ApplicationId",
                table: "JobInterviews",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_JobInterviews_SheduledBy",
                table: "JobInterviews",
                column: "SheduledBy");

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplications_JobPosts_JobPost_id",
                table: "JobApplications",
                column: "JobPost_id",
                principalTable: "JobPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplications_JobSeekers_Applicant",
                table: "JobApplications",
                column: "Applicant",
                principalTable: "JobSeekers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplications_Resumes_Resume_id",
                table: "JobApplications",
                column: "Resume_id",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobInterviews_CompanyUsers_SheduledBy",
                table: "JobInterviews",
                column: "SheduledBy",
                principalTable: "CompanyUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobInterviews_JobApplications_ApplicationId",
                table: "JobInterviews",
                column: "ApplicationId",
                principalTable: "JobApplications",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobInterviews_JobProviderCompanies_CompanyId",
                table: "JobInterviews",
                column: "CompanyId",
                principalTable: "JobProviderCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobInterviews_JobSeekers_interviewee",
                table: "JobInterviews",
                column: "interviewee",
                principalTable: "JobSeekers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_CompanyUsers_PostedBy",
                table: "JobPosts",
                column: "PostedBy",
                principalTable: "CompanyUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Industries_IndustryId",
                table: "JobPosts",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_JobCategories_Category",
                table: "JobPosts",
                column: "Category",
                principalTable: "JobCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_JobProviderCompanies_CompanyId",
                table: "JobPosts",
                column: "CompanyId",
                principalTable: "JobProviderCompanies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Locations_LocationNavigationId",
                table: "JobPosts",
                column: "LocationNavigationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobProviderCompanies_Industries_IndustryId",
                table: "JobProviderCompanies",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobProviderCompanies_Locations_LocationId",
                table: "JobProviderCompanies",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_JobPosts_JobPost_id",
                table: "JobApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_JobSeekers_Applicant",
                table: "JobApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_Resumes_Resume_id",
                table: "JobApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobInterviews_CompanyUsers_SheduledBy",
                table: "JobInterviews");

            migrationBuilder.DropForeignKey(
                name: "FK_JobInterviews_JobApplications_ApplicationId",
                table: "JobInterviews");

            migrationBuilder.DropForeignKey(
                name: "FK_JobInterviews_JobProviderCompanies_CompanyId",
                table: "JobInterviews");

            migrationBuilder.DropForeignKey(
                name: "FK_JobInterviews_JobSeekers_interviewee",
                table: "JobInterviews");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_CompanyUsers_PostedBy",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Industries_IndustryId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_JobCategories_Category",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_JobProviderCompanies_CompanyId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Locations_LocationNavigationId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobProviderCompanies_Industries_IndustryId",
                table: "JobProviderCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_JobProviderCompanies_Locations_LocationId",
                table: "JobProviderCompanies");

            migrationBuilder.DropTable(
                name: "AuthUser");

            migrationBuilder.DropIndex(
                name: "IX_JobProviderCompanies_IndustryId",
                table: "JobProviderCompanies");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_Category",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_CompanyId",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_IndustryId",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_PostedBy",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobInterviews_ApplicationId",
                table: "JobInterviews");

            migrationBuilder.DropIndex(
                name: "IX_JobInterviews_SheduledBy",
                table: "JobInterviews");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "IndustryId",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                table: "JobInterviews");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "JobInterviews");

            migrationBuilder.DropColumn(
                name: "SheduledBy",
                table: "JobInterviews");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "CompanyUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "CompanyUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "CompanyUsers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "CompanyUsers");

            migrationBuilder.DropColumn(
                name: "Roles",
                table: "CompanyUsers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "CompanyUsers");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "JobProviderCompanies",
                newName: "LocationNavigationId");

            migrationBuilder.RenameColumn(
                name: "IndustryId",
                table: "JobProviderCompanies",
                newName: "Location");

            migrationBuilder.RenameIndex(
                name: "IX_JobProviderCompanies_LocationId",
                table: "JobProviderCompanies",
                newName: "IX_JobProviderCompanies_LocationNavigationId");

            migrationBuilder.RenameColumn(
                name: "LocationNavigationId",
                table: "JobPosts",
                newName: "PostedByNavigationId");

            migrationBuilder.RenameIndex(
                name: "IX_JobPosts_LocationNavigationId",
                table: "JobPosts",
                newName: "IX_JobPosts_PostedByNavigationId");

            migrationBuilder.RenameColumn(
                name: "interviewee",
                table: "JobInterviews",
                newName: "JobApplicationId");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "JobInterviews",
                newName: "ScheduledById");

            migrationBuilder.RenameIndex(
                name: "IX_JobInterviews_interviewee",
                table: "JobInterviews",
                newName: "IX_JobInterviews_JobApplicationId");

            migrationBuilder.RenameIndex(
                name: "IX_JobInterviews_CompanyId",
                table: "JobInterviews",
                newName: "IX_JobInterviews_ScheduledById");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "JobApplications",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "Datesubmitted",
                table: "JobApplications",
                newName: "DateSubmitted");

            migrationBuilder.RenameColumn(
                name: "Resume_id",
                table: "JobApplications",
                newName: "ResumeId");

            migrationBuilder.RenameColumn(
                name: "JobPost_id",
                table: "JobApplications",
                newName: "JobPostId");

            migrationBuilder.RenameColumn(
                name: "Applicant",
                table: "JobApplications",
                newName: "ApplicantId");

            migrationBuilder.RenameIndex(
                name: "IX_JobApplications_Resume_id",
                table: "JobApplications",
                newName: "IX_JobApplications_ResumeId");

            migrationBuilder.RenameIndex(
                name: "IX_JobApplications_JobPost_id",
                table: "JobApplications",
                newName: "IX_JobApplications_JobPostId");

            migrationBuilder.RenameIndex(
                name: "IX_JobApplications_Applicant",
                table: "JobApplications",
                newName: "IX_JobApplications_ApplicantId");

            migrationBuilder.AddColumn<Guid>(
                name: "JobPost",
                table: "Skills",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "JobPostNavigationId",
                table: "Skills",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "JobSeekerProfileId",
                table: "Skills",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Industry",
                table: "JobProviderCompanies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "PostedBy",
                table: "JobPosts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "JobLocation",
                table: "JobPosts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Category",
                table: "JobPosts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Company",
                table: "JobPosts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Industry",
                table: "JobPosts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "JobLocationNavigationId",
                table: "JobPosts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "PostedDate",
                table: "JobPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateScheduled",
                table: "JobInterviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "IntervieweeId",
                table: "JobInterviews",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "AuthUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthUsers_SystemUsers_Id",
                        column: x => x.Id,
                        principalTable: "SystemUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Skills_JobPostNavigationId",
                table: "Skills",
                column: "JobPostNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_JobLocationNavigationId",
                table: "JobPosts",
                column: "JobLocationNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_JobInterviews_IntervieweeId",
                table: "JobInterviews",
                column: "IntervieweeId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplications_JobPosts_JobPostId",
                table: "JobApplications",
                column: "JobPostId",
                principalTable: "JobPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplications_JobSeekers_ApplicantId",
                table: "JobApplications",
                column: "ApplicantId",
                principalTable: "JobSeekers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplications_Resumes_ResumeId",
                table: "JobApplications",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobInterviews_CompanyUsers_ScheduledById",
                table: "JobInterviews",
                column: "ScheduledById",
                principalTable: "CompanyUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobInterviews_JobApplications_JobApplicationId",
                table: "JobInterviews",
                column: "JobApplicationId",
                principalTable: "JobApplications",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobInterviews_JobSeekers_IntervieweeId",
                table: "JobInterviews",
                column: "IntervieweeId",
                principalTable: "JobSeekers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_CompanyUsers_PostedByNavigationId",
                table: "JobPosts",
                column: "PostedByNavigationId",
                principalTable: "CompanyUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Locations_JobLocationNavigationId",
                table: "JobPosts",
                column: "JobLocationNavigationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobProviderCompanies_Locations_LocationNavigationId",
                table: "JobProviderCompanies",
                column: "LocationNavigationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_JobPosts_JobPostNavigationId",
                table: "Skills",
                column: "JobPostNavigationId",
                principalTable: "JobPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
