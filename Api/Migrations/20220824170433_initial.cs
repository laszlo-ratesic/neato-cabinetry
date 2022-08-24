﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Budget = table.Column<int>(type: "INTEGER", nullable: false),
                    Photo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Address", "Budget", "Country", "Description", "Photo" },
                values: new object[] { 1, "12 Valley of Kings, Geneva", 900000, "Switzerland", "A superb detached Victorian property on one of the town's finest roads, within easy reach of Barnes Village. The property has in excess of 6000 sq/ft of accommodation, a driveway and landscaped garden.", null });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Address", "Budget", "Country", "Description", "Photo" },
                values: new object[] { 2, "89 Road of Forks, Bern", 500000, "Switzerland", "This impressive family home, which dates back to approximately 1840, offers original period features throughout and is set back from the road with off street parking for up to six cars and an original Coach Project, which has been incorporated into the main Project to provide further accommodation. ", null });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Address", "Budget", "Country", "Description", "Photo" },
                values: new object[] { 3, "Grote Hof 12, Amsterdam", 200500, "The Netherlands", "This Project has been designed and built to an impeccable standard offering luxurious and elegant living. The accommodation is arranged over four floors comprising a large entrance hall, living room with tall sash windows, dining room, study and WC on the ground floor.", null });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Address", "Budget", "Country", "Description", "Photo" },
                values: new object[] { 4, "Meel Kade 321, The Hague", 259500, "The Netherlands", "Discreetly situated a unique two storey period home enviably located on the corner of Krom Road and Recht Road offering seclusion and privacy. The Project features a magnificent double height reception room with doors leading directly out onto a charming courtyard garden.", null });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Address", "Budget", "Country", "Description", "Photo" },
                values: new object[] { 5, "Oude Gracht 32, Utrecht", 400500, "The Netherlands", "This luxurious three bedroom flat is contemporary in style and benefits from the use of a gymnasium and a reserved underground parking space.", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
