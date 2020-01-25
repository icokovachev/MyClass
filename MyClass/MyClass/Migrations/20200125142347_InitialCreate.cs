using Microsoft.EntityFrameworkCore.Migrations;

namespace MyClass.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    SchoolID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    IdentityID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassID = table.Column<long>(nullable: false),
                    SchoolID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.IdentityID);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    IdentityID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(nullable: true),
                    SchoolID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.IdentityID);
                });

            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Exam_Classes_ClassID",
                        column: x => x.ClassID,
                        principalTable: "Classes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Homeworks",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homeworks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Homeworks_Classes_ClassID",
                        column: x => x.ClassID,
                        principalTable: "Classes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WeeklySchedules",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeeklySchedules", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WeeklySchedules_Classes_ClassID",
                        column: x => x.ClassID,
                        principalTable: "Classes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Events_Schools_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "Schools",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_SchoolID",
                table: "Events",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_ClassID",
                table: "Exam",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Homeworks_ClassID",
                table: "Homeworks",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_WeeklySchedules_ClassID",
                table: "WeeklySchedules",
                column: "ClassID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Exam");

            migrationBuilder.DropTable(
                name: "Homeworks");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "WeeklySchedules");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "Classes");
        }
    }
}
