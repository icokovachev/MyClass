using Microsoft.EntityFrameworkCore.Migrations;

namespace MyClass.Migrations
{
    public partial class SchoolAndClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SchoolID",
                table: "Teachers",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassID",
                table: "Students",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_SchoolID",
                table: "Classes",
                column: "SchoolID");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Schools_SchoolID",
                table: "Classes",
                column: "SchoolID",
                principalTable: "Schools",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classes_ClassID",
                table: "Students",
                column: "ClassID",
                principalTable: "Classes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Schools_SchoolID",
                table: "Teachers",
                column: "SchoolID",
                principalTable: "Schools",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Schools_SchoolID",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classes_ClassID",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Schools_SchoolID",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_SchoolID",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Students_ClassID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Classes_SchoolID",
                table: "Classes");
        }
    }
}
