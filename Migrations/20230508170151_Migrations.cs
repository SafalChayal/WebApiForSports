using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSportsAPI.Migrations
{
    /// <inheritdoc />
    public partial class Migrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    Sport_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sport_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sport_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sport_Team_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Start_Month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    End_Month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sport_Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.Sport_Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Player_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PLayer_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Player_Age = table.Column<int>(type: "int", nullable: false),
                    Player_Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Player_Salary = table.Column<long>(type: "bigint", nullable: false),
                    Sport_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Player_Id);
                    table.ForeignKey(
                        name: "FK_Players_Sports_Sport_Id",
                        column: x => x.Sport_Id,
                        principalTable: "Sports",
                        principalColumn: "Sport_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_Sport_Id",
                table: "Players",
                column: "Sport_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Sports");
        }
    }
}
