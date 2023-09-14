using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEccomerce.Server.Migrations
{
    public partial class NewChanges2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Developer", "ImageUrl", "Price", "ReleaseYear", "Title" },
                values: new object[] { "Introducing the Xbox Series S, the smallest, sleekest Xbox console ever. Experience the speed and performance of a next-gen all-digital console at an accessible price point. Go all-digital and enjoy disc-free, next-gen gaming with the smallest Xbox console ever made.", "Microsoft", "https://m.media-amazon.com/images/I/61mnlvScHxL._AC_SL1500_.jpg", 249.99m, 2020, "Xbox Series S" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Introducing Xbox Series X, the fastest, most powerful Xbox ever. Play thousands of titles from four generations of consoles—all games look and play best on Xbox Series X.", "https://m.media-amazon.com/images/I/41NhM7MMj4L._AC_SL1080_.jpg", 469.23m, "Xbox Series X" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Developer", "ImageUrl", "Price", "ReleaseYear", "Title" },
                values: new object[] { "Rediscover your favourite 80s videogames in HD! Each title for the Nintendo Classic Mini: Nintendo Entertainment System is displayed at a smooth 60Hz via the included HDMI cable and can be enjoyed in one of three visual modes!.", "Nintendo", "https://m.media-amazon.com/images/I/71GIan4mDmL._AC_SL1500_.jpg", 199.96m, 1985, "Nintendo Classic Mini: Nintendo Entertainment System (Electronic Games)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "Price", "ReleaseYear", "Title" },
                values: new object[] { "The Nintendo Classic Mini: Super Nintendo Entertainment System has the same look and feel of the original system only smaller and comes pre-loaded with 21 games.Launched in Europe in 1992, the Super Nintendo introduced what many consider some of the greatest video games of all timeX.", "https://m.media-amazon.com/images/I/81SVwPdq3tL._AC_SL1500_.jpg", 268.39m, 1992, "Nintendo Classic Mini Console: Super Nintendo Entertainment System" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "Price", "ReleaseYear", "Title" },
                values: new object[] { "The new system features a vibrant 7-inch OLED screen, a wide adjustable stand, a dock with a wired LAN port, 64 GB of internal storage, and enhanced audio.", "https://m.media-amazon.com/images/I/51K6gw94TRL._AC_SL1200_.jpg", 289.00m, 2021, "Nintendo Switch (OLED Model) - White" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Developer", "ImageUrl", "Price", "ReleaseYear", "Title" },
                values: new object[] { "PC gaming has never been this portable - the ASUS ROG Ally puts a Windows gaming machine in the palm of your hands. And it doesn't compromise on specs. It packs an impressive AMD Ryzen Z1 Extreme CPU with Radeon graphics. So it's got plenty of horsepower to run your favourites. They'll look amazing on the 7” Full HD touchscreen. And with refresh rate up to 120 Hz, they'll be gloriously smooth, too. To match the amazing visuals, there are Dolby Atmos speakers that'll draw you into the game. And with battery life up to 8 hours, you can have a proper gaming sesh wherever you are.", "ASUS", "https://media.currys.biz/i/currysprod/10249544?$l-large$&fmt=auto", 699.00m, 2023, "ASUS ROG Ally Handheld Gaming Console" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Introducing the Xbox Series S, the smallest, sleekest Xbox console ever. Experience the speed and performance of a next-gen all-digital console at an accessible price point. Go all-digital and enjoy disc-free, next-gen gaming with the smallest Xbox console ever made.", "https://m.media-amazon.com/images/I/61mnlvScHxL._AC_SL1500_.jpg", 249.99m, "Xbox Series S" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Developer", "ImageUrl", "Price", "ReleaseYear", "Title" },
                values: new object[] { "Introducing Xbox Series X, the fastest, most powerful Xbox ever. Play thousands of titles from four generations of consoles—all games look and play best on Xbox Series X.", "Microsoft", "https://m.media-amazon.com/images/I/41NhM7MMj4L._AC_SL1080_.jpg", 469.23m, 2020, "Xbox Series X" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "Price", "ReleaseYear", "Title" },
                values: new object[] { "Rediscover your favourite 80s videogames in HD! Each title for the Nintendo Classic Mini: Nintendo Entertainment System is displayed at a smooth 60Hz via the included HDMI cable and can be enjoyed in one of three visual modes!.", "https://m.media-amazon.com/images/I/71GIan4mDmL._AC_SL1500_.jpg", 199.96m, 1985, "Nintendo Classic Mini: Nintendo Entertainment System (Electronic Games)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "Price", "ReleaseYear", "Title" },
                values: new object[] { "The Nintendo Classic Mini: Super Nintendo Entertainment System has the same look and feel of the original system only smaller and comes pre-loaded with 21 games.Launched in Europe in 1992, the Super Nintendo introduced what many consider some of the greatest video games of all timeX.", "https://m.media-amazon.com/images/I/81SVwPdq3tL._AC_SL1500_.jpg", 268.39m, 1992, "Nintendo Classic Mini Console: Super Nintendo Entertainment System" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Developer", "ImageUrl", "Price", "ReleaseYear", "Title" },
                values: new object[] { 12, 1, "The new system features a vibrant 7-inch OLED screen, a wide adjustable stand, a dock with a wired LAN port, 64 GB of internal storage, and enhanced audio.", "Nintendo", "https://m.media-amazon.com/images/I/51K6gw94TRL._AC_SL1200_.jpg", 289.00m, 2021, "Nintendo Switch (OLED Model) - White" });
        }
    }
}
