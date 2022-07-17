using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.AspNetCore.Identity;
namespace API.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(StoreContext context,UserManager<User> userManager)
        {
             if (!userManager.Users.Any())
            {
                var user = new User
                {
                    UserName = "argim",
                    Email = "argim@test.com"
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
                await userManager.AddToRoleAsync(user, "Member");

                var admin = new User
                {
                    UserName = "admin",
                    Email = "admin@test.com"
                };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] {"Member", "Admin"});
            }


            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = " Brembo Brake Disc",
                    Description =
                        "BREMBO XTRA LINE 09.9772.1X Brake Disc - Perforated / Vented, Coated, High-carbon, with bolts/screws",
                    Price = 7000,
                    PictureUrl = "/images/products/brake-disc.png",
                    Brand = "Brembo",
                    Type = "Brakes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Brembo Brake pads",
                    Description = "BREMBO LP565 Brake pad set - not prepared for wear indicator, without anti-squeak plate, with accessories",
                    Price = 20000,
                    PictureUrl = "/images/products/brake-pads.png",
                    Brand = "BREMBO",
                    Type = "Brakes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Ridex Brake Drum",
                    Description =
                        "RIDEX 123B0032 Brake Drum - without wheel bearing, without wheel hub, without wheel studs, 240mm, Rear Axle",
                    Price = 20000,
                    PictureUrl = "/images/products/brake-drum.png",
                    Brand = "RIDEX",
                    Type = "Brakes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Ridex Camshaft",
                    Description =
                        "RIDEX 566C0019 Camshaft",
                    Price = 10000,
                    PictureUrl = "/images/products/camshaft.png",
                    Brand = "RIDEX",
                    Type = "Engine",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Ridex Water Pump",
                    Description =
                        "RIDEX 1260W0021 Water Pump - Aluminium, with seal ring",
                    Price = 80000,
                    PictureUrl = "/images/products/water-pump.png",
                    Brand = "RIDEX",
                    Type = "Engine",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "VDO Mass Air Flow",
                    Description =
                        "VDO 5WK9606Z Mass air flow sensor ",
                    Price = 400000,
                    PictureUrl = "/images/products/air-flow.png",
                    Brand = "VDO",
                    Type = "Engine",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Ridex Turbocharger",
                    Description =   
                        "RIDEX 2234C0016 Turbocharger - without gaskets/seals ",
                    Price = 500000,
                    PictureUrl = "/images/products/turbo-charger.png",
                    Brand = "RIDEX",
                    Type = "Engine",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "K&N Filters Air Filter",
                    Description =
                        "K&N Filters 33-3028 Air Filter - Long-life Filter",
                    Price = 8000,
                    PictureUrl = "/images/products/air-filter.png",
                    Brand = "K&N",
                    Type = "Filters",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Blue Print Oil Filter",
                    Description =
                        "BLUE PRINT ADH22114 Oil Filter - Spin-on Filter",
                    Price = 15000,
                    PictureUrl = "/images/products/oil-filter.png",
                    Brand = "BLUE PRINT",
                    Type = "Filters",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Mann-Filters Fuel Filter",
                    Description =
                        "MANN-FILTER WK 820/17 Fuel filter - In-Line Filter",
                    Price = 65000,
                    PictureUrl = "/images/products/fuel-filter.png",
                    Brand = "MANN-FILTERS",
                    Type = "Filters",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Meyle Mounting Manual Transmission",
                    Description =
                        "MEYLE 100 199 0053 Mounting, manual transmission - Left Front, ORIGINAL Quality",
                    Price = 600000,
                    PictureUrl = "/images/products/mount.png",
                    Brand = "MEYLE",
                    Type = "Transmission",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Meyle Oil Pan Manual Transmission",
                    Description =
                        "MEYLE 300 325 0000 Oil Pan, manual transmission - with seal, with filter, ORIGINAL Quality",
                    Price = 80000,
                    PictureUrl = "/images/products/oil-pan.png",
                    Brand = "MEYLE",
                    Type = "Transmission",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Ashika Anti Roll Bar",
                    Description =
                        "ASHIKA 106-02-214 Anti roll bar - Front Axle, 24mm",
                    Price = 60000,
                    PictureUrl = "/images/products/anti-roll.png",
                    Brand = "ASHIKA",
                    Type = "Suspension",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Lemforder Mounting Axcel Bracket",
                    Description =
                        "LEMFÖRDER 35315 01 Mounting, axle bracket for supsension test ",
                    Price = 75000,
                    PictureUrl = "/images/products/axel.png",
                    Brand = "Lemforder",
                    Type = "Suspension",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "LuK Dual Mass Flywheel",
                    Description =
                        "LuK 415 0477 10 Dual mass flywheel - Number of mounting holes: 6 - Number of teeth (determination of the max. clearance angle): 7",
                    Price = 700000,
                    PictureUrl = "/images/products/fly-wheel.png",
                    Brand = "LUK",
                    Type = "Clutch",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Ridex Clutch Disc",
                    Description =
                        "RIDEX 262C0003 Clutch Disc - 210mm, Teeth Quant.: 28",
                    Price = 19999,
                    PictureUrl = "/images/products/clutch-disc.png",
                    Brand = "RIDEX",
                    Type = "Clutch",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Ridex Clutch Kit",
                    Description = "RIDEX 479C0049 Clutch Kit - for engines with dual-mass flywheel, with central slave cylinder, with clutch pressure plate, with clutch disc, with flywheel, with screw set",
                    Price = 1000000,
                    PictureUrl = "/images/products/clutch-kit.png",
                    Brand = "RIDEX",
                    Type = "Clutch",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Mapco Pollen Filter",
                    Description =
                        "MAPCO 65531 Pollen filter - Pollen Filter",
                    Price = 18000,
                    PictureUrl = "/images/products/pollen.png",
                    Brand = "MAPCO",
                    Type = "Filters",
                    QuantityInStock = 100
                },
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}