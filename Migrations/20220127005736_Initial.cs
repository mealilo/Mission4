using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission4.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category = table.Column<string>(type: "TEXT", nullable: false),
                    title = table.Column<string>(type: "TEXT", nullable: false),
                    year = table.Column<int>(type: "INTEGER", nullable: false),
                    director = table.Column<string>(type: "TEXT", nullable: false),
                    rating = table.Column<string>(type: "TEXT", nullable: false),
                    edited = table.Column<bool>(type: "INTEGER", nullable: false),
                    lentTo = table.Column<string>(type: "TEXT", nullable: true),
                    notes = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.MovieID);
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "MovieID", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 1, "Action", "Quentin", false, "Bob", "Very Good", "PG-13", "Incredibles", 2009 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "MovieID", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 2, "Comedy", "Jack Black", true, "Bob", "", "PG-13", "Wahtever", 2109 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "MovieID", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 3, "Drama", "Other", true, "Jack", "Very Good", "R", "Yeet", 2009 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
