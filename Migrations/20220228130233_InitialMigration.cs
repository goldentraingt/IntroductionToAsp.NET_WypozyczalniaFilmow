using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IntroductionToAsp.NET_WypozyczalniaFilmow.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Straszne Moviey", "Horror" },
                    { 2, "Movie oparty na faktach", "Dokumentalny" },
                    { 3, "Dreszczowce", "Thriller" },
                    { 4, "Moviey z akcja", "Sensacyjne" },
                    { 5, "Elementy magiczne i nadprzyrodzone", "Fantasy" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "Director", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "20 sierpnia 1973 roku teksańska policja trafiła do stojącego na uboczu domu Thomasa Hewitta - byłego pracownika lokalnej rzeźni. Na miejscu odkryli rozkładające się zwłoki 33 osób, które zostały zamordowane przez psychopatycznego zabójcę noszącego na twarzy maskę z ludzkiej skóry i posługującego się piłą mechaniczną.", "Marcus Nispel", 10m, "Teksańska Masakra Piłą Mechaniczną" },
                    { 9, 1, new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frank Cotton nabywa tajemniczą kostkę, za pomocą której można przywołać demony z piekła.", "Clive Barker", 16m, "Hellraiser: Wysłannik Piekieł" },
                    { 6, 2, new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dziennikarz śledczy rozmawia z dziewięcioma księżmi katolickimi, którzy dopuścili się zbrodni pedofilii i molestowania nieletnich, a także ich ofiarami.", "Tomasz Sekielski", 0m, "Tylko nie mów nikomu" },
                    { 2, 3, new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mężczyzna dostaje obsesji na punkcie książki, która według niego opisuje i przewiduje jego życie i przyszłość.", "Joel Schumacher", 14m, "Numer 23" },
                    { 3, 3, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uznany pisarz przenosi się na prowincję, by w spokoju tworzyć kolejne książki. Wkrótce odwiedzi go tajemniczy mężczyzna, który oskarży Raineya o plagiat.", "David Koepp", 12m, "Sekretne Okno" },
                    { 8, 3, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grupa osób budzi się w pełnym śmiertelnych pułapek sześcianie. Nieznajomi muszą zacząć współpracować ze sobą, by przeżyć.", "Vincenzo Natali", 15m, "Cube" },
                    { 10, 3, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seryjny morderca i inteligentna agentka łączą siły, by znaleźć przestępcę obdzierającego ze skóry swoje ofiary.", "Jonathan Demme", 17m, "Milczenie Owiec" },
                    { 5, 4, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emerytowani agenci specjalni CIA zostają wrobieni w zamach. By się ratować, muszą reaktywować stary zespół.", "Robert Schwentke", 11m, "Red" },
                    { 4, 5, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Podróż hobbita z Shire i jego ośmiu towarzyszy, której celem jest zniszczenie potężnego pierścienia pożądanego przez Czarnego Władcę - Saurona.", "Peter Jackson", 20m, "Władca Pierścieni: Drużyna Pierścienia" },
                    { 7, 5, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wiedeń u progu XX w. Syn rzemieślnika, iluzjonista Eisenheim, wykorzystuje niezwykłe umiejętności, by zdobyć miłość arystokratki, narzeczonej austro-węgierskiego księcia.", "Neil Burger", 13m, "Iluzjonista" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CategoryId",
                table: "Movies",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
