using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PopAlexandru_Proiect2.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PublishedBook_Car_CarID",
                table: "PublishedBook");

            migrationBuilder.DropForeignKey(
                name: "FK_PublishedBook_Publisher_PublisherID",
                table: "PublishedBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PublishedBook",
                table: "PublishedBook");

            migrationBuilder.RenameTable(
                name: "PublishedBook",
                newName: "PublishedCar");

            migrationBuilder.RenameIndex(
                name: "IX_PublishedBook_PublisherID",
                table: "PublishedCar",
                newName: "IX_PublishedCar_PublisherID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PublishedCar",
                table: "PublishedCar",
                columns: new[] { "CarID", "PublisherID" });

            migrationBuilder.AddForeignKey(
                name: "FK_PublishedCar_Car_CarID",
                table: "PublishedCar",
                column: "CarID",
                principalTable: "Car",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PublishedCar_Publisher_PublisherID",
                table: "PublishedCar",
                column: "PublisherID",
                principalTable: "Publisher",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PublishedCar_Car_CarID",
                table: "PublishedCar");

            migrationBuilder.DropForeignKey(
                name: "FK_PublishedCar_Publisher_PublisherID",
                table: "PublishedCar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PublishedCar",
                table: "PublishedCar");

            migrationBuilder.RenameTable(
                name: "PublishedCar",
                newName: "PublishedBook");

            migrationBuilder.RenameIndex(
                name: "IX_PublishedCar_PublisherID",
                table: "PublishedBook",
                newName: "IX_PublishedBook_PublisherID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PublishedBook",
                table: "PublishedBook",
                columns: new[] { "CarID", "PublisherID" });

            migrationBuilder.AddForeignKey(
                name: "FK_PublishedBook_Car_CarID",
                table: "PublishedBook",
                column: "CarID",
                principalTable: "Car",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PublishedBook_Publisher_PublisherID",
                table: "PublishedBook",
                column: "PublisherID",
                principalTable: "Publisher",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
