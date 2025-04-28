using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class updated2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthUser_SystemUsers_Id",
                table: "AuthUser");

            migrationBuilder.DropForeignKey(
                name: "FK_JobProviderCompanies_Industries_IndustryNavigationId",
                table: "JobProviderCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_JobProviderCompanies_Locations_LocationNavigationId",
                table: "JobProviderCompanies");

            migrationBuilder.DropIndex(
                name: "IX_JobProviderCompanies_IndustryNavigationId",
                table: "JobProviderCompanies");

            migrationBuilder.DropColumn(
                name: "Industry",
                table: "JobProviderCompanies");

            migrationBuilder.DropColumn(
                name: "IndustryNavigationId",
                table: "JobProviderCompanies");

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

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "AuthUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AuthUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AuthUser",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "AuthUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "AuthUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "AuthUser",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobProviderCompanies_IndustryId",
                table: "JobProviderCompanies",
                column: "IndustryId");

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
                name: "FK_JobProviderCompanies_Industries_IndustryId",
                table: "JobProviderCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_JobProviderCompanies_Locations_LocationId",
                table: "JobProviderCompanies");

            migrationBuilder.DropIndex(
                name: "IX_JobProviderCompanies_IndustryId",
                table: "JobProviderCompanies");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "AuthUser");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AuthUser");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AuthUser");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "AuthUser");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AuthUser");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "AuthUser");

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

            migrationBuilder.AddColumn<Guid>(
                name: "Industry",
                table: "JobProviderCompanies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IndustryNavigationId",
                table: "JobProviderCompanies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_JobProviderCompanies_IndustryNavigationId",
                table: "JobProviderCompanies",
                column: "IndustryNavigationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthUser_SystemUsers_Id",
                table: "AuthUser",
                column: "Id",
                principalTable: "SystemUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobProviderCompanies_Industries_IndustryNavigationId",
                table: "JobProviderCompanies",
                column: "IndustryNavigationId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobProviderCompanies_Locations_LocationNavigationId",
                table: "JobProviderCompanies",
                column: "LocationNavigationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
