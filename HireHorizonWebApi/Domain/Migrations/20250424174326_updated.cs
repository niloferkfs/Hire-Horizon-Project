using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_CompanyUsers_CompanyUserId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_JobCategories_JobCategoryId",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_CompanyUserId",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_JobCategoryId",
                table: "JobPosts");

            migrationBuilder.RenameColumn(
                name: "JobCategoryId",
                table: "JobPosts",
                newName: "PostedById");

            migrationBuilder.RenameColumn(
                name: "CompanyUserId",
                table: "JobPosts",
                newName: "CompanyId");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "JobPosts",
                type: "uniqueidentifier",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "CategoryId",
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

            migrationBuilder.RenameColumn(
                name: "PostedById",
                table: "JobPosts",
                newName: "JobCategoryId");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "JobPosts",
                newName: "CompanyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_CompanyUserId",
                table: "JobPosts",
                column: "CompanyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_JobCategoryId",
                table: "JobPosts",
                column: "JobCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_CompanyUsers_CompanyUserId",
                table: "JobPosts",
                column: "CompanyUserId",
                principalTable: "CompanyUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_JobCategories_JobCategoryId",
                table: "JobPosts",
                column: "JobCategoryId",
                principalTable: "JobCategories",
                principalColumn: "Id");
        }
    }
}
