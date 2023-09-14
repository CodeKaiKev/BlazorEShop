using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEccomerce.Server.Migrations
{
    public partial class NewChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Developer",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReleaseYear",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 1, "Console", "console" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 2, "Video Game", "videogame" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 3, "Accessories", "accessories" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "Developer", "ImageUrl", "Price", "ReleaseYear", "Title" },
                values: new object[] { 1, "A new generation of gaming with enhanced graphics and social features.\r\nThe Dualshock controller has been redesigned and enhanced for a more comfortable and responsive gameplay experience.", "Sony", "https://www-konga-com-res.cloudinary.com/w_400,f_auto,fl_lossy,dpr_3.0,q_auto/media/catalog/product/L/Y/124977_1646511717.jpg", 119.99m, 2016, "PlayStation 4 500GB - Good Condition" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "Developer", "ImageUrl", "Price", "ReleaseYear", "Title" },
                values: new object[] { 1, "PlayStation 4 Pro - the super charged PS4 - take play to the next level with PS4 Pro: See every detail explode into life with 4K gaming and entertainment, experience faster, smoother frame rates and more powerful gaming performance and enjoy richer, more vibrant colours with HDR technology.", "Sony", "https://m.media-amazon.com/images/I/61UZ8FqIUWL._AC_SL1500_.jpg", 269.99m, 2016, "Sony PlayStation 4 Pro Console - Black - 1TB (Renewed)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "Developer", "ImageUrl", "Price", "ReleaseYear", "Title" },
                values: new object[] { 1, "The console features a hardware on-the-fly zlib decompression module. The original PS4 model supports up to 1080p and 1080i video standards, while the Pro model supports 4K resolution.", "Sony", "https://m.media-amazon.com/images/I/51o960aJ--L._AC_SL1000_.jpg", 201.99m, 2016, "Sony CUH-2216A PlayStation 4 Slim 500GB Games Console Jet Black" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Developer", "ImageUrl", "Price", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 4, 1, "The PS5 console unleashes new gaming possibilities that you never anticipated Experience lightning-fast loading with an ultra-high-speed SSD, deeper immersion with support for haptic feedback, adaptive triggers and 3D Audio, and an all-new generation of incredible PlayStation games", "Sony", "https://m.media-amazon.com/images/I/71p6rZnGPoL._AC_SL1500_.jpg", 389.00m, 2020, "PlayStation 5 Digital Console" },
                    { 5, 1, "7' diagonal, Optically bonded IPS LCD for enhanced readability, 1280 x 800px (16:10 aspect ratio), 60Hz, 400 nits typical 64 GB eMMC (PCIe Gen 2 x1), 16 GB LPDDR5 on-board RAM (5500 MT/s quad 32-bit channels), microSD Expansion: UHS-I supports SD, SDXC and SDHC", "Steam", "https://m.media-amazon.com/images/I/61ekQQCkRRL._AC_SL1500_.jpg", 421.00m, 2022, "Valve Steam Deck 64GB eMMC + 16GB RAM, 7' inch, 60Hz, 1280 x 800px, SteamOS 3.0, Handheld Gaming Console" },
                    { 6, 1, "PC gaming has never been this portable - the ASUS ROG Ally puts a Windows gaming machine in the palm of your hands. And it doesn't compromise on specs. It packs an impressive AMD Ryzen Z1 Extreme CPU with Radeon graphics. So it's got plenty of horsepower to run your favourites. They'll look amazing on the 7” Full HD touchscreen. And with refresh rate up to 120 Hz, they'll be gloriously smooth, too. To match the amazing visuals, there are Dolby Atmos speakers that'll draw you into the game. And with battery life up to 8 hours, you can have a proper gaming sesh wherever you are.", "ASUS", "https://media.currys.biz/i/currysprod/10249544?$l-large$&fmt=auto", 699.00m, 2023, "ASUS ROG Ally Handheld Gaming Console" },
                    { 7, 1, "PC gaming has never been this portable - the ASUS ROG Ally puts a Windows gaming machine in the palm of your hands. And it doesn't compromise on specs. It packs an impressive AMD Ryzen Z1 Extreme CPU with Radeon graphics. So it's got plenty of horsepower to run your favourites. They'll look amazing on the 7” Full HD touchscreen. And with refresh rate up to 120 Hz, they'll be gloriously smooth, too. To match the amazing visuals, there are Dolby Atmos speakers that'll draw you into the game. And with battery life up to 8 hours, you can have a proper gaming sesh wherever you are.", "ASUS", "https://media.currys.biz/i/currysprod/10249544?$l-large$&fmt=auto", 699.00m, 2023, "ASUS ROG Ally Handheld Gaming Console" },
                    { 8, 1, "Introducing the Xbox Series S, the smallest, sleekest Xbox console ever. Experience the speed and performance of a next-gen all-digital console at an accessible price point. Go all-digital and enjoy disc-free, next-gen gaming with the smallest Xbox console ever made.", "Microsoft", "https://m.media-amazon.com/images/I/61mnlvScHxL._AC_SL1500_.jpg", 249.99m, 2020, "Xbox Series S" },
                    { 9, 1, "Introducing Xbox Series X, the fastest, most powerful Xbox ever. Play thousands of titles from four generations of consoles—all games look and play best on Xbox Series X.", "Microsoft", "https://m.media-amazon.com/images/I/41NhM7MMj4L._AC_SL1080_.jpg", 469.23m, 2020, "Xbox Series X" },
                    { 10, 1, "Rediscover your favourite 80s videogames in HD! Each title for the Nintendo Classic Mini: Nintendo Entertainment System is displayed at a smooth 60Hz via the included HDMI cable and can be enjoyed in one of three visual modes!.", "Nintendo", "https://m.media-amazon.com/images/I/71GIan4mDmL._AC_SL1500_.jpg", 199.96m, 1985, "Nintendo Classic Mini: Nintendo Entertainment System (Electronic Games)" },
                    { 11, 1, "The Nintendo Classic Mini: Super Nintendo Entertainment System has the same look and feel of the original system only smaller and comes pre-loaded with 21 games.Launched in Europe in 1992, the Super Nintendo introduced what many consider some of the greatest video games of all timeX.", "Nintendo", "https://m.media-amazon.com/images/I/81SVwPdq3tL._AC_SL1500_.jpg", 268.39m, 1992, "Nintendo Classic Mini Console: Super Nintendo Entertainment System" },
                    { 12, 1, "The new system features a vibrant 7-inch OLED screen, a wide adjustable stand, a dock with a wired LAN port, 64 GB of internal storage, and enhanced audio.", "Nintendo", "https://m.media-amazon.com/images/I/51K6gw94TRL._AC_SL1200_.jpg", 289.00m, 2021, "Nintendo Switch (OLED Model) - White" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Developer",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ReleaseYear",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "The console features a hardware on-the-fly zlib decompression module. The original PS4 model supports up to 1080p and 1080i video standards, while the Pro model supports 4K resolution.", "https://m.media-amazon.com/images/I/51o960aJ--L._AC_SL1000_.jpg", 201.99m, "Sony CUH-2216A PlayStation 4 Slim 500GB Games Console Jet Black" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "The PS5 console unleashes new gaming possibilities that you never anticipated Experience lightning-fast loading with an ultra-high-speed SSD, deeper immersion with support for haptic feedback, adaptive triggers and 3D Audio, and an all-new generation of incredible PlayStation games", "https://m.media-amazon.com/images/I/71p6rZnGPoL._AC_SL1500_.jpg", 389.00m, "PlayStation 5 Digital Console" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "7' diagonal, Optically bonded IPS LCD for enhanced readability, 1280 x 800px (16:10 aspect ratio), 60Hz, 400 nits typical 64 GB eMMC (PCIe Gen 2 x1), 16 GB LPDDR5 on-board RAM (5500 MT/s quad 32-bit channels), microSD Expansion: UHS-I supports SD, SDXC and SDHC", "https://m.media-amazon.com/images/I/61ekQQCkRRL._AC_SL1500_.jpg", 421.00m, "Valve Steam Deck 64GB eMMC + 16GB RAM, 7' inch, 60Hz, 1280 x 800px, SteamOS 3.0, Handheld Gaming Console" });
        }
    }
}
