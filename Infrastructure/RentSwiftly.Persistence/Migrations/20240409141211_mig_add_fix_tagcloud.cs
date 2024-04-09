using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentSwiftly.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_fix_tagcloud : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlodID",
                table: "TagClouds");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlodID",
                table: "TagClouds",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
