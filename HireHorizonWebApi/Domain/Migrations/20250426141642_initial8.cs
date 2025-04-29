using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class initial8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_CompanyUsers_PostedByNavigationId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Locations_JobLocationNavigationId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobProviderCompanies_Locations_LocationNavigationId",
                table: "JobProviderCompanies");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_JobLocationNavigationId",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_PostedByNavigationId",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "Industry",
                table: "JobProviderCompanies");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "Industry",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "JobLocation",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "JobLocationNavigationId",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "PostedBy",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "PostedByNavigationId",
                table: "JobPosts");

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

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "JobPosts",
                type: "uniqueidentifier",
                nullable: true);

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
                name: "LocationId",
                table: "JobPosts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PostedById",
                table: "JobPosts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobProviderCompanies_IndustryId",
                table: "JobProviderCompanies",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_CategoryId",
                table: "JobPosts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_CompanyId",
                table: "JobPosts",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_IndustryId",
                table: "JobPosts",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_LocationId",
                table: "JobPosts",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_PostedById",
                table: "JobPosts",
                column: "PostedById");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_CompanyUsers_PostedById",
                table: "JobPosts",
                column: "PostedById",
                principalTable: "CompanyUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Industries_IndustryId",
                table: "JobPosts",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_JobCategories_CategoryId",
                table: "JobPosts",
                column: "CategoryId",
                principalTable: "JobCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_JobProviderCompanies_CompanyId",
                table: "JobPosts",
                column: "CompanyId",
                principalTable: "JobProviderCompanies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Locations_LocationId",
                table: "JobPosts",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id");

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
                name: "FK_JobPosts_CompanyUsers_PostedById",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Industries_IndustryId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_JobCategories_CategoryId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_JobProviderCompanies_CompanyId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Locations_LocationId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobProviderCompanies_Industries_IndustryId",
                table: "JobProviderCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_JobProviderCompanies_Locations_LocationId",
                table: "JobProviderCompanies");

            migrationBuilder.DropIndex(
                name: "IX_JobProviderCompanies_IndustryId",
                table: "JobProviderCompanies");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_CategoryId",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_CompanyId",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_IndustryId",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_LocationId",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_PostedById",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "IndustryId",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "PostedById",
                table: "JobPosts");

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
                name: "Category",
                table: "JobPosts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                name: "JobLocation",
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

            migrationBuilder.AddColumn<Guid>(
                name: "PostedBy",
                table: "JobPosts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PostedByNavigationId",
                table: "JobPosts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_JobLocationNavigationId",
                table: "JobPosts",
                column: "JobLocationNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_PostedByNavigationId",
                table: "JobPosts",
                column: "PostedByNavigationId");

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
        }
    }
}
