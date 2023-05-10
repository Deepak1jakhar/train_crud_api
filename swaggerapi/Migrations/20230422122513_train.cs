using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace swaggerapi.Migrations
{
    /// <inheritdoc />
    public partial class train : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.CreateTable(
                name: "Train",
                columns: table => new
                {
                    trainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    trainName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    from = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    to = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Train", x => x.trainId);
                });

            migrationBuilder.InsertData(
                table: "Train",
                columns: new[] { "trainId", "from", "to", "trainName" },
                values: new object[,]
                {
                    { 12131, "Pune", "Mumbai", "Vande Bharat" },
                    { 12132, "Mumbai", "Pune", "Vande Bharat" },
                    { 12535, "Uk", "Delhi", "Kathgodam Express" },
                    { 12732, "Delhi", "Jalandhar", "Sarbat Da Bhala" },
                    { 12733, "Delhi", "Jalandhar", "Andaman Express" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Train");

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "deepak@gmail.com", "Deepak" },
                    { 2, "vijay@gmail.com", "Vijay" },
                    { 3, "inter@gmail.com", "Inter" }
                });
        }
    }
}
