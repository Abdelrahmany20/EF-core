using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_core.Migrations
{
    /// <inheritdoc />
    public partial class AddCourse_instractorTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "course_instractor",
                columns: table => new
                {
                    course_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    instractor_id = table.Column<int>(type: "int", nullable: false),
                    evaluate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course_instractor", x => x.course_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "course_instractor");
        }
    }
}
