using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BoardGameLibraryInClass.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoardGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublisherId = table.Column<int>(type: "int", nullable: false),
                    PublisherModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardGames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoardGames_Publishers_PublisherModelId",
                        column: x => x.PublisherModelId,
                        principalTable: "Publishers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "BoardGames",
                columns: new[] { "Id", "Description", "ImageURL", "Name", "PublisherId", "PublisherModelId" },
                values: new object[,]
                {
                    { 1, "Control one fantasy race after another to expand throught the land", "https://cf.geekdo-images.com/aoPM07XzoceB-RydLh08zA__imagepage/img/lHmv0ddOrUvpiLcPeQbZdT5yCEA=/fit-in/900x600/filters:no_upscale():strip_icc()/pic428828.jpg", "SmallWorld", 1, null },
                    { 2, "Attract a beautiful and diverse collection of birds to your wildwife preserve", "https://cf.geekdo-images.com/yLZJCVLlIx4c7eJEWUNJ7w__imagepagezoom/img/yS4vL6iTCvHSvGySxyOjV_-R3dI=/fit-in/1200x900/filters:no_upscale():strip_icc()/pic4458123.jpg", "WingSpan", 2, null },
                    { 3, "Ticket to Ride Board Game | Family Board Game | Board Game for Adults and Family", "https://m.media-amazon.com/images/I/91YNJM4oyhL._AC_UL400_.jpg", "Ticket to ride", 1, null },
                    { 4, "You are a monarch, like your parents before you, a ruler of a small pleasant kingdom of rivers and evergreens. Unlike your parents, however, you have hopes and dreams!", "https://cf.geekdo-images.com/j6iQpZ4XkemZP07HNCODBA__imagepage/img/bbKggiASKA1E8sAh2cH07czaGn4=/fit-in/900x600/filters:no_upscale():strip_icc()/pic394356.jpg", "Dominion", 3, null },
                    { 5, "In the Magic game, you play the role of a planeswalker—a powerful wizard who fights other planeswalkers for glory, knowledge, and conquest. Your deck of cards represents all the weapons in your arsenal. It contains the spells you know and the creatures you can summon to fight for you.", "https://cf.geekdo-images.com/CxJmNl4wR4InjqyNrMdBTw__imagepage/img/G185gILyaxGCYka6LwuEhd9--WA=/fit-in/900x600/filters:no_upscale():strip_icc()/pic163749.jpg", "Magic the Gathering", 4, null },
                    { 6, "Move assassins, elders & builders through Naqala to claim oases & control djinns.", "https://cf.geekdo-images.com/dmo-WD6HZHVUPrbVHunaTw__imagepage/img/6Zrd6v5Z7gukQ-18akZ2hesGr_c=/fit-in/900x600/filters:no_upscale():strip_icc()/pic2055255.jpg", "Five Tribes", 1, null },
                    { 7, "t's a fight to the death when giant monsters battle over Tokyo in this dice-roller.", "https://cf.geekdo-images.com/m_RzXpHURC0_xLkvRSR_sw__imagepage/img/oSNvtltDuWj3LP74IEFj8Ov2B0k=/fit-in/900x600/filters:no_upscale():strip_icc()/pic3043734.jpg", "King of Tokoyo", 4, null }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Days of Wonder" },
                    { 2, "Stonemaier Games" },
                    { 3, "Rio Grande" },
                    { 4, "Richard Garfield" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoardGames_PublisherModelId",
                table: "BoardGames",
                column: "PublisherModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoardGames");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
