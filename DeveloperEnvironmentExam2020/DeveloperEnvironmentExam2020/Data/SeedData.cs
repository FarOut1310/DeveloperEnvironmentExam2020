using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeveloperEnvironmentExam2020.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DeveloperEnvironmentExam2020.Data
{
    public class SeedData
    {
        public static void AddCategories(IServiceProvider serviceProvider)
        {
            using (var context = new CategoryContext(
                serviceProvider.GetRequiredService<DbContextOptions<CategoryContext>>()))
            {
                if (context.Categories.Any())
                {
                    return;
                }

                context.Categories.AddRange(
                    new Category
                    {
                        Name = "Beverages",
                        Description = "Liquid beverages in various packaging. Includes juices, soft drinks, etc."
                    },
                    new Category
                    {
                        Name = "Salty Snacks",
                        Description = "Bagged salty snackfoods. Includes various chips, nuts, etc."
                    },
                    new Category
                    {
                        Name = "Frozen Vegetables",
                        Description = "Bagged frozen vegetable. Must be kept cool until used."
                    },
                    new Category
                    {
                        Name = "Sweets",
                        Description = "Sweet baked goods and candy."
                    }
                    );
                context.SaveChanges();
            }
        }

        public static void AddProducts(IServiceProvider serviceProvider)
        {
            using (var context = new ProductContext(
                serviceProvider.GetRequiredService<DbContextOptions<ProductContext>>()))
            {
                if (context.Products.Any())
                {
                    return;
                }

                context.Products.AddRange(
                    new Product
                    {
                        Name = "Rema1000 Multifrugt Juice",
                        Description = "Sund og lækker juice fra blandede frugter",
                        Unit = "Liters",
                        Amount = 1,
                        Price = 11.99,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Name = "Rema1000 Hyldeblomstsaft",
                        Description = "Lækker saft fra frisk hyldeblomst, klar til blanding",
                        Unit = "Liters",
                        Amount = 1,
                        Price = 9.99,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Name = "Rema1000 Peanuts",
                        Description = "Ristede og saltede peanuts",
                        Unit = "Grams",
                        Amount = 250,
                        Price = 10.59,
                        CategoryId = 2
                    },
                    new Product
                    {
                        Name = "Rema1000 Flæskesvær",
                        Description = "Sprøde gammeldags flæskesvær",
                        Unit = "Grams",
                        Amount = 150,
                        Price = 7.99,
                        CategoryId = 2
                    },
                    new Product
                    {
                        Name = "Rema1000 Brocoli",
                        Description = "Dybfrosset brocoli klar til optøgning og kogning",
                        Unit = "Kilograms",
                        Amount = 1,
                        Price = 14.50,
                        CategoryId = 3
                    },
                    new Product
                    {
                        Name = "Rema1000 Grøntsags Blanding",
                        Description = "Blandede dybfrossne grøntsager, klar til optøgning og kogning",
                        Unit = "Kilograms",
                        Amount = 2,
                        Price = 19.50,
                        CategoryId = 3
                    },
                    new Product
                    {
                        Name = "Rema1000 Småkager",
                        Description = "Smørbagte kager med chokolade",
                        Unit = "Pieces",
                        Amount = 12,
                        Price = 9.95,
                        CategoryId = 4
                    },
                    new Product
                    {
                        Name = "Haribo Stjernemix",
                        Description = "Blandede frugt vingummi og lakrids",
                        Unit = "Grams",
                        Amount = 200,
                        Price = 24.50,
                        CategoryId = 4
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
