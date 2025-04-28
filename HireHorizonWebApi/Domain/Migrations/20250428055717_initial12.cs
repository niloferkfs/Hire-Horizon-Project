using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class initial12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "FK_JobPosts_CompanyUsers_PostedById",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_JobPosts_JobPostNavigationId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_JobPostNavigationId",
                table: "Skills");

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
                name: "DateScheduled",
                table: "JobInterviews");

            migrationBuilder.DropColumn(
                name: "IntervieweeId",
                table: "JobInterviews");

            migrationBuilder.RenameColumn(
                name: "PostedById",
                table: "JobPosts",
                newName: "PostedBy");

            migrationBuilder.RenameIndex(
                name: "IX_JobPosts_PostedById",
                table: "JobPosts",
                newName: "IX_JobPosts_PostedBy");

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

            migrationBuilder.AddColumn<Guid>(
                name: "SkillId",
                table: "JobSeekerProfiles",
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

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerProfiles_SkillId",
                table: "JobSeekerProfiles",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_JobInterviews_ApplicationId",
                table: "JobInterviews",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_JobInterviews_SheduledBy",
                table: "JobInterviews",
                column: "SheduledBy");

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
                name: "FK_JobSeekerProfiles_Skills_SkillId",
                table: "JobSeekerProfiles",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "FK_JobSeekerProfiles_Skills_SkillId",
                table: "JobSeekerProfiles");

            migrationBuilder.DropIndex(
                name: "IX_JobSeekerProfiles_SkillId",
                table: "JobSeekerProfiles");

            migrationBuilder.DropIndex(
                name: "IX_JobInterviews_ApplicationId",
                table: "JobInterviews");

            migrationBuilder.DropIndex(
                name: "IX_JobInterviews_SheduledBy",
                table: "JobInterviews");

            migrationBuilder.DropColumn(
                name: "SkillId",
                table: "JobSeekerProfiles");

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
                name: "PostedBy",
                table: "JobPosts",
                newName: "PostedById");

            migrationBuilder.RenameIndex(
                name: "IX_JobPosts_PostedBy",
                table: "JobPosts",
                newName: "IX_JobPosts_PostedById");

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

            migrationBuilder.CreateIndex(
                name: "IX_Skills_JobPostNavigationId",
                table: "Skills",
                column: "JobPostNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_JobInterviews_IntervieweeId",
                table: "JobInterviews",
                column: "IntervieweeId");

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
                name: "FK_JobPosts_CompanyUsers_PostedById",
                table: "JobPosts",
                column: "PostedById",
                principalTable: "CompanyUsers",
                principalColumn: "Id");

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
