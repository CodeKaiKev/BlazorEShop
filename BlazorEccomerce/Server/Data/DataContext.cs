
namespace BlazorEccomerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {

        }
        // Seed Data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Sony",
                    Url = "sony"
                },
                new Category
                {
                    Id = 2,
                    Name = "Nintendo",
                    Url = "nintendo"
                },
                new Category
                {
                    Id = 3,
                    Name = "Microsft",
                    Url = "microsoft"
                },
                new Category
                {
                    Id = 4,
                    Name = "Other",
                    Url = "other"
                }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "PlayStation 4 500GB - Good Condition",
                    Description = "A new generation of gaming with enhanced graphics and social features.\r\nThe Dualshock controller has been redesigned and enhanced for a more comfortable and responsive gameplay experience.",
                    ImageUrl = "https://www-konga-com-res.cloudinary.com/w_400,f_auto,fl_lossy,dpr_3.0,q_auto/media/catalog/product/L/Y/124977_1646511717.jpg",
                    Price = 119.99M,
                    ReleaseYear = 2016,
                    Developer = "Sony",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "Sony PlayStation 4 Pro Console - Black - 1TB (Renewed)",
                    Description = "PlayStation 4 Pro - the super charged PS4 - take play to the next level with PS4 Pro: See every detail explode into life with 4K gaming and entertainment, experience faster, smoother frame rates and more powerful gaming performance and enjoy richer, more vibrant colours with HDR technology.",
                    ImageUrl = "https://m.media-amazon.com/images/I/61UZ8FqIUWL._AC_SL1500_.jpg",
                    Price = 269.99M,
                    ReleaseYear = 2016,
                    Developer = "Sony",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "Sony CUH-2216A PlayStation 4 Slim 500GB Games Console Jet Black",
                    Description = "The console features a hardware on-the-fly zlib decompression module. The original PS4 model supports up to 1080p and 1080i video standards, while the Pro model supports 4K resolution.",
                    ImageUrl = "https://m.media-amazon.com/images/I/51o960aJ--L._AC_SL1000_.jpg",
                    Price = 201.99M,
                    ReleaseYear = 2016,
                    Developer = "Sony",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 4,
                    Title = "PlayStation 5 Digital Console",
                    Description = "The PS5 console unleashes new gaming possibilities that you never anticipated Experience lightning-fast loading with an ultra-high-speed SSD, deeper immersion with support for haptic feedback, adaptive triggers and 3D Audio, and an all-new generation of incredible PlayStation games",
                    ImageUrl = "https://m.media-amazon.com/images/I/71p6rZnGPoL._AC_SL1500_.jpg",
                    Price = 389.00M,
                    ReleaseYear = 2020,
                    Developer = "Sony",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 5,
                    Title = "Valve Steam Deck 64GB eMMC + 16GB RAM, 7' inch, 60Hz, 1280 x 800px, SteamOS 3.0, Handheld Gaming Console",
                    Description = "7' diagonal, Optically bonded IPS LCD for enhanced readability, 1280 x 800px (16:10 aspect ratio), 60Hz, 400 nits typical 64 GB eMMC (PCIe Gen 2 x1), 16 GB LPDDR5 on-board RAM (5500 MT/s quad 32-bit channels), microSD Expansion: UHS-I supports SD, SDXC and SDHC",
                    ImageUrl = "https://m.media-amazon.com/images/I/61ekQQCkRRL._AC_SL1500_.jpg",
                    Price = 421.00M,
                    ReleaseYear = 2022,
                    Developer = "Steam",
                    CategoryId = 4
                },
                new Product
                {
                    Id = 6,
                    Title = "ASUS ROG Ally Handheld Gaming Console",
                    Description = "PC gaming has never been this portable - the ASUS ROG Ally puts a Windows gaming machine in the palm of your hands. And it doesn't compromise on specs. It packs an impressive AMD Ryzen Z1 Extreme CPU with Radeon graphics. So it's got plenty of horsepower to run your favourites. They'll look amazing on the 7” Full HD touchscreen. And with refresh rate up to 120 Hz, they'll be gloriously smooth, too. To match the amazing visuals, there are Dolby Atmos speakers that'll draw you into the game. And with battery life up to 8 hours, you can have a proper gaming sesh wherever you are.",
                    ImageUrl = "https://media.currys.biz/i/currysprod/10249544?$l-large$&fmt=auto",
                    Price = 699.00M,
                    ReleaseYear = 2023,
                    Developer = "ASUS",
                    CategoryId = 4
                },
                new Product
                {
                    Id = 7,
                    Title = "Xbox Series S",
                    Description = "Introducing the Xbox Series S, the smallest, sleekest Xbox console ever. Experience the speed and performance of a next-gen all-digital console at an accessible price point. Go all-digital and enjoy disc-free, next-gen gaming with the smallest Xbox console ever made.",
                    ImageUrl = "https://m.media-amazon.com/images/I/61mnlvScHxL._AC_SL1500_.jpg",
                    Price = 249.99M,
                    ReleaseYear = 2020,
                    Developer = "Microsoft",
                    CategoryId = 3
                },
                new Product
                {
                    Id = 8,
                    Title = "Xbox Series X",
                    Description = "Introducing Xbox Series X, the fastest, most powerful Xbox ever. Play thousands of titles from four generations of consoles—all games look and play best on Xbox Series X.",
                    ImageUrl = "https://m.media-amazon.com/images/I/41NhM7MMj4L._AC_SL1080_.jpg",
                    Price = 469.23M,
                    ReleaseYear = 2020,
                    Developer = "Microsoft",
                    CategoryId = 3
                },
                new Product
                {
                    Id = 9,
                    Title = "Nintendo Classic Mini: Nintendo Entertainment System (Electronic Games)",
                    Description = "Rediscover your favourite 80s videogames in HD! Each title for the Nintendo Classic Mini: Nintendo Entertainment System is displayed at a smooth 60Hz via the included HDMI cable and can be enjoyed in one of three visual modes!.",
                    ImageUrl = "https://m.media-amazon.com/images/I/71GIan4mDmL._AC_SL1500_.jpg",
                    Price = 199.96M,
                    ReleaseYear = 1985,
                    Developer = "Nintendo",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 10,
                    Title = "Nintendo Classic Mini Console: Super Nintendo Entertainment System",
                    Description = "The Nintendo Classic Mini: Super Nintendo Entertainment System has the same look and feel of the original system only smaller and comes pre-loaded with 21 games.Launched in Europe in 1992, the Super Nintendo introduced what many consider some of the greatest video games of all timeX.",
                    ImageUrl = "https://m.media-amazon.com/images/I/81SVwPdq3tL._AC_SL1500_.jpg",
                    Price = 268.39M,
                    ReleaseYear = 1992,
                    Developer = "Nintendo",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 11,
                    Title = "Nintendo Switch (OLED Model) - White",
                    Description = "The new system features a vibrant 7-inch OLED screen, a wide adjustable stand, a dock with a wired LAN port, 64 GB of internal storage, and enhanced audio.",
                    ImageUrl = "https://m.media-amazon.com/images/I/51K6gw94TRL._AC_SL1200_.jpg",
                    Price = 289.00M,
                    ReleaseYear = 2021,
                    Developer = "Nintendo",
                    CategoryId = 2
                }
            );
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
