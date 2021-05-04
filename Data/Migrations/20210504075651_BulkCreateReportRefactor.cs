using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.QendraFolApi.Data.Migrations
{
    public partial class BulkCreateReportRefactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImportFailedIds",
                table: "BulkCreateReport",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImportFailedIds",
                table: "BulkCreateReport");
        }
    }
}
