using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagementSystem_CodeFirst.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Addresses_AdminNo",
                table: "Students");

            migrationBuilder.AlterColumn<string>(
                name: "AdminNo",
                table: "Addresses",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AdminNo",
                table: "Addresses",
                column: "AdminNo",
                unique: true,
                filter: "[AdminNo] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Students_AdminNo",
                table: "Addresses",
                column: "AdminNo",
                principalTable: "Students",
                principalColumn: "AdminNo",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Students_AdminNo",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_AdminNo",
                table: "Addresses");

            migrationBuilder.AlterColumn<string>(
                name: "AdminNo",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Addresses_AdminNo",
                table: "Students",
                column: "AdminNo",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
