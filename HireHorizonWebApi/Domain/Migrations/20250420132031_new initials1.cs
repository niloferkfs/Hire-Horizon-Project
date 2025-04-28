using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class newinitials1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "JobSeekerId",
                table: "JobSeekerProfiles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerProfiles_JobSeekers_JobSeekerId",
                table: "JobSeekerProfiles");

            migrationBuilder.DropIndex(
                name: "IX_JobSeekerProfiles_JobSeekerId",
                table: "JobSeekerProfiles");

            migrationBuilder.DropColumn(
                name: "JobSeekerId",
                table: "JobSeekerProfiles");
        }
    }
}
