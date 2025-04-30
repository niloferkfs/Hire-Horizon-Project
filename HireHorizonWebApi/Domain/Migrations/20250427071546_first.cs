using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_JobCategories_Category",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Locations_LocationNavigationId",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_LocationNavigationId",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "LocationNavigationId",
                table: "JobPosts");

            migrationBuilder.RenameColumn(
                name: "JobLocation",
                table: "JobPosts",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "JobPosts",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_JobPosts_Category",
                table: "JobPosts",
                newName: "IX_JobPosts_CategoryId");

            migrationBuilder.AddColumn<DateTime>(
                name: "PostedDate",
                table: "JobPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_LocationId",
                table: "JobPosts",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_JobCategories_CategoryId",
                table: "JobPosts",
                column: "CategoryId",
                principalTable: "JobCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Locations_LocationId",
                table: "JobPosts",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_JobCategories_CategoryId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Locations_LocationId",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_LocationId",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "PostedDate",
                table: "JobPosts");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "JobPosts",
                newName: "JobLocation");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "JobPosts",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_JobPosts_CategoryId",
                table: "JobPosts",
                newName: "IX_JobPosts_Category");

            migrationBuilder.AddColumn<Guid>(
                name: "LocationNavigationId",
                table: "JobPosts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_LocationNavigationId",
                table: "JobPosts",
                column: "LocationNavigationId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_JobCategories_Category",
                table: "JobPosts",
                column: "Category",
                principalTable: "JobCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Locations_LocationNavigationId",
                table: "JobPosts",
                column: "LocationNavigationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
