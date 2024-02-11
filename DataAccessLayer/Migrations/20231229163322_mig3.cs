using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogID",
                table: "Coments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Coments_BlogID",
                table: "Coments",
                column: "BlogID");

            migrationBuilder.AddForeignKey(
                name: "FK_Coments_Blogs_BlogID",
                table: "Coments",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coments_Blogs_BlogID",
                table: "Coments");

            migrationBuilder.DropIndex(
                name: "IX_Coments_BlogID",
                table: "Coments");

            migrationBuilder.DropColumn(
                name: "BlogID",
                table: "Coments");
        }
    }
}
