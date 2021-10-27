using Microsoft.EntityFrameworkCore.Migrations;

namespace ClientSideInterface.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "System",
                columns: table => new
                {
                    SystemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System", x => x.SystemID);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SystemID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    systemModelSystemID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Games_System_systemModelSystemID",
                        column: x => x.systemModelSystemID,
                        principalTable: "System",
                        principalColumn: "SystemID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "ID", "Genere", "Rating", "SystemID", "Title", "systemModelSystemID" },
                values: new object[,]
                {
                    { 1, "Sport", "E", 1, "Mario Kart 8", null },
                    { 18, "Strategy", "T", 4, "Sins of a Solar Empire", null },
                    { 17, "Strategy", "T", 4, "Europa Universalis 4", null },
                    { 16, "Sport", "E", 5, "NBA 2K21", null },
                    { 15, "Sport", "E", 2, "FIFA 21", null },
                    { 14, "Simulation", "E", 4, "Kerbal Space Program", null },
                    { 13, "Simulation", "E", 4, "Cities: Skylines", null },
                    { 11, "Role-Playing", "M", 2, "The Witcher 3: Wild Hunt", null },
                    { 10, "Casual", "E", 1, "Super Mario Party", null },
                    { 12, "Role-Playing", "M", 4, "Fallout: New Vegas", null },
                    { 8, "Action", "M", 4, "Back 4 Blood", null },
                    { 7, "Action", "M", 5, "Far Cry 6", null },
                    { 6, "Strategy", "E 10+", 4, "Civilization", null },
                    { 5, "Role-Playing", "M", 5, "Assasins Creed", null },
                    { 4, "Simulation", "E", 4, "Microsoft Flight Simulatior", null },
                    { 3, "Casual", "E", 3, "Candy Crush", null },
                    { 2, "Action", "M", 2, "Halo", null },
                    { 9, "Casual", "E", 4, "Minecraft", null }
                });

            migrationBuilder.InsertData(
                table: "System",
                columns: new[] { "SystemID", "Brand", "Name" },
                values: new object[,]
                {
                    { 4, "Microsoft", "Windows" },
                    { 1, "Nintendo", "Switch" },
                    { 2, "Microsoft", "XBox" },
                    { 3, "Apple", "IOS" },
                    { 5, "Sony", "Playstation" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_systemModelSystemID",
                table: "Games",
                column: "systemModelSystemID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "System");
        }
    }
}
