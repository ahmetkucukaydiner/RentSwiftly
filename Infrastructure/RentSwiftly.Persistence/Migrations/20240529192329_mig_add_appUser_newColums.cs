using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentSwiftly.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_appUser_newColums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "AppUsers");
        }
    }
}
