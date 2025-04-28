using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class updated3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerProfiles_Resumes_ResumeId",
                table: "JobSeekerProfiles");

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

            migrationBuilder.AlterColumn<string>(
                name: "CoverLetter",
                table: "JobApplications",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                name: "IX_JobSeekerProfiles_JobSeekerId",
                table: "JobSeekerProfiles",
                column: "JobSeekerId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerProfiles_JobSeekers_JobSeekerId",
                table: "JobSeekerProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerProfiles_Resumes_ResumeId",
                table: "JobSeekerProfiles");

            migrationBuilder.DropIndex(
                name: "IX_JobSeekerProfiles_JobSeekerId",
                table: "JobSeekerProfiles");

            migrationBuilder.DropColumn(
                name: "JobSeekerId",
                table: "JobSeekerProfiles");

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
