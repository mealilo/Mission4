using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission4.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    categoryID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    categoryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.categoryID);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    title = table.Column<string>(type: "TEXT", nullable: false),
                    year = table.Column<int>(type: "INTEGER", nullable: false),
                    director = table.Column<string>(type: "TEXT", nullable: false),
                    rating = table.Column<string>(type: "TEXT", nullable: false),
                    edited = table.Column<bool>(type: "INTEGER", nullable: false),
                    lentTo = table.Column<string>(type: "TEXT", nullable: true),
                    notes = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true),
                    categoryID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.MovieID);
                    table.ForeignKey(
                        name: "FK_Movie_Categories_categoryID",
                        column: x => x.categoryID,
                        principalTable: "Categories",
                        principalColumn: "categoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 1, "Comedy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 2, "Drama" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryID", "categoryName" },
                values: new object[] { 3, "Horror" });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "MovieID", "categoryID", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 1, 1, "Quentin", false, "Bob", "Very Good", "PG-13", "Incredibles", 2009 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "MovieID", "categoryID", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 2, 1, "Jack Black", true, "Bob", "", "PG-13", "Wahtever", 2109 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "MovieID", "categoryID", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 3, 1, "Other", true, "Jack", "Very Good", "R", "Yeet", 2009 });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_categoryID",
                table: "Movie",
                column: "categoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
