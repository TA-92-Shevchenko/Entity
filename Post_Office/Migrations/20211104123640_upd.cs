using Microsoft.EntityFrameworkCore.Migrations;

namespace Post_Office.Migrations
{
    public partial class upd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nchar(6)", fixedLength: true, maxLength: 6, nullable: false),
                    Phone_number = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nchar(25)", fixedLength: true, maxLength: 25, nullable: true),
                    parcel_id = table.Column<int>(type: "int", nullable: false),
                    Bonus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "parcel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    weight = table.Column<double>(type: "float", nullable: false),
                    height = table.Column<double>(type: "float", nullable: false),
                    adress_id = table.Column<string>(type: "nchar(5)", fixedLength: true, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parcel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    First_name = table.Column<string>(type: "nchar(25)", fixedLength: true, maxLength: 25, nullable: false),
                    Last_name = table.Column<string>(type: "nchar(25)", fixedLength: true, maxLength: 25, nullable: false),
                    Client_Id = table.Column<string>(type: "nchar(6)", fixedLength: true, maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Post_office",
                columns: table => new
                {
                    adress_id = table.Column<string>(type: "nchar(5)", fixedLength: true, maxLength: 5, nullable: false),
                    post_office = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post_office", x => x.adress_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "parcel");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Post_office");
        }
    }
}
