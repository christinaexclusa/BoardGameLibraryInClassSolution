using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoardGameLibraryInClass.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoardGames_Publishers_PublisherModelId",
                table: "BoardGames");

            migrationBuilder.DropIndex(
                name: "IX_BoardGames_PublisherModelId",
                table: "BoardGames");

            migrationBuilder.DropColumn(
                name: "PublisherModelId",
                table: "BoardGames");

            migrationBuilder.CreateIndex(
                name: "IX_BoardGames_PublisherId",
                table: "BoardGames",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_BoardGames_Publishers_PublisherId",
                table: "BoardGames",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoardGames_Publishers_PublisherId",
                table: "BoardGames");

            migrationBuilder.DropIndex(
                name: "IX_BoardGames_PublisherId",
                table: "BoardGames");

            migrationBuilder.AddColumn<int>(
                name: "PublisherModelId",
                table: "BoardGames",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublisherModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublisherModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublisherModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublisherModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublisherModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublisherModelId",
                value: null);

            migrationBuilder.UpdateData(
                table: "BoardGames",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublisherModelId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_BoardGames_PublisherModelId",
                table: "BoardGames",
                column: "PublisherModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_BoardGames_Publishers_PublisherModelId",
                table: "BoardGames",
                column: "PublisherModelId",
                principalTable: "Publishers",
                principalColumn: "Id");
        }
    }
}
