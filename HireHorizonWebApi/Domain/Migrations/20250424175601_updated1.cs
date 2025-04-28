using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class updated1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_CompanyUsers_PostedByNavigationId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_JobCategories_CategoryNavigationId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_JobProviderCompanies_CompanyNavigationId",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_CategoryNavigationId",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_CompanyNavigationId",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_PostedByNavigationId",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "CategoryNavigationId",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "CompanyNavigationId",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "PostedByNavigationId",
                table: "JobPosts");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_CategoryId",
                table: "JobPosts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_CompanyId",
                table: "JobPosts",
                column: "CompanyId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_CompanyUsers_PostedById",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_JobCategories_CategoryId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_JobProviderCompanies_CompanyId",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_CategoryId",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_CompanyId",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_PostedById",
                table: "JobPosts");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryNavigationId",
                table: "JobPosts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyNavigationId",
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
                name: "IX_JobPosts_CategoryNavigationId",
                table: "JobPosts",
                column: "CategoryNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_CompanyNavigationId",
                table: "JobPosts",
                column: "CompanyNavigationId");

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
                name: "FK_JobPosts_JobCategories_CategoryNavigationId",
                table: "JobPosts",
                column: "CategoryNavigationId",
                principalTable: "JobCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_JobProviderCompanies_CompanyNavigationId",
                table: "JobPosts",
                column: "CompanyNavigationId",
                principalTable: "JobProviderCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
