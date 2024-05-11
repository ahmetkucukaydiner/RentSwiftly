using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentSwiftly.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_comment_email : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserImageUrl",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Comments");

            migrationBuilder.AlterColumn<string>(
                name: "UserImageUrl",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
