using Microsoft.EntityFrameworkCore.Migrations;

namespace Jobs_KS.Data.Migrations
{
    public partial class addedImageToJob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Jobs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Jobs");
        }
    }
}
