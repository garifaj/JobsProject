using Microsoft.EntityFrameworkCore.Migrations;

namespace Jobs_KS.Data.Migrations
{
    public partial class addedJobTypeToJobTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Jobs",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "JobTypeId",
                table: "Jobs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_JobTypeId",
                table: "Jobs",
                column: "JobTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_JobTypes_JobTypeId",
                table: "Jobs",
                column: "JobTypeId",
                principalTable: "JobTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_JobTypes_JobTypeId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_JobTypeId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "JobTypeId",
                table: "Jobs");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Jobs",
                newName: "Id");
        }
    }
}
