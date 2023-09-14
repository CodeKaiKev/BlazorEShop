using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEccomerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "The console features a hardware on-the-fly zlib decompression module. The original PS4 model supports up to 1080p and 1080i video standards, while the Pro model supports 4K resolution.", "https://m.media-amazon.com/images/I/51o960aJ--L._AC_SL1000_.jpg", 201.99m, "Sony CUH-2216A PlayStation 4 Slim 500GB Games Console Jet Black" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "The PS5 console unleashes new gaming possibilities that you never anticipated Experience lightning-fast loading with an ultra-high-speed SSD, deeper immersion with support for haptic feedback, adaptive triggers and 3D Audio, and an all-new generation of incredible PlayStation games", "https://m.media-amazon.com/images/I/71p6rZnGPoL._AC_SL1500_.jpg", 389.00m, "PlayStation 5 Digital Console" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "7' diagonal, Optically bonded IPS LCD for enhanced readability, 1280 x 800px (16:10 aspect ratio), 60Hz, 400 nits typical 64 GB eMMC (PCIe Gen 2 x1), 16 GB LPDDR5 on-board RAM (5500 MT/s quad 32-bit channels), microSD Expansion: UHS-I supports SD, SDXC and SDHC", "https://m.media-amazon.com/images/I/61ekQQCkRRL._AC_SL1500_.jpg", 421.00m, "Valve Steam Deck 64GB eMMC + 16GB RAM, 7' inch, 60Hz, 1280 x 800px, SteamOS 3.0, Handheld Gaming Console" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
