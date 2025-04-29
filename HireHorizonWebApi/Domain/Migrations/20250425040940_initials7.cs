using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class initials7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthUser_SystemUsers_Id",
                table: "AuthUser");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddForeignKey(
                name: "FK_AuthUser_SystemUsers_Id",
                table: "AuthUser",
                column: "Id",
                principalTable: "SystemUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
