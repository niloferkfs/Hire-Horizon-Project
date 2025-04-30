using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class lastone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_JobSeekerProfiles_Resumes_ResumeId",
                table: "JobSeekerProfiles");

            migrationBuilder.RenameColumn(
                name: "Discription",
                table: "Locations",
                newName: "Description");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "ResumeId",
                table: "JobSeekerProfiles",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "JobSeekerId",
                table: "JobSeekerProfiles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SkillId",
                table: "JobSeekerProfiles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CoverLetter",
                table: "JobApplications",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "AuthUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerProfiles_JobSeekerId",
                table: "JobSeekerProfiles",
                column: "JobSeekerId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerProfiles_SkillId",
                table: "JobSeekerProfiles",
                column: "SkillId");

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
                name: "FK_JobSeekerProfiles_JobSeekers_JobSeekerId",
                table: "JobSeekerProfiles",
                column: "JobSeekerId",
                principalTable: "JobSeekers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekerProfiles_Resumes_ResumeId",
                table: "JobSeekerProfiles",
                column: "ResumeId",
                principalTable: "Resumes",
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
                name: "FK_JobApplications_JobPosts_JobPostId",
                table: "JobApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_JobSeekers_ApplicantId",
                table: "JobApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_Resumes_ResumeId",
                table: "JobApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerProfiles_JobSeekers_JobSeekerId",
                table: "JobSeekerProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerProfiles_Resumes_ResumeId",
                table: "JobSeekerProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerProfiles_Skills_SkillId",
                table: "JobSeekerProfiles");

            migrationBuilder.DropIndex(
                name: "IX_JobSeekerProfiles_JobSeekerId",
                table: "JobSeekerProfiles");

            migrationBuilder.DropIndex(
                name: "IX_JobSeekerProfiles_SkillId",
                table: "JobSeekerProfiles");

            migrationBuilder.DropColumn(
                name: "JobSeekerId",
                table: "JobSeekerProfiles");

            migrationBuilder.DropColumn(
                name: "SkillId",
                table: "JobSeekerProfiles");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Locations",
                newName: "Discription");

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
                name: "ResumeId",
                table: "JobSeekerProfiles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CoverLetter",
                table: "JobApplications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "AuthUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                name: "FK_JobSeekerProfiles_Resumes_ResumeId",
                table: "JobSeekerProfiles",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
