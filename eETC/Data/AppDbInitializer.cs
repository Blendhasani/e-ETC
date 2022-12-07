using eETC.Data.Enum;
using eETC.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eETC.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();



                //States


                if (!context.States.Any())
                {
                    context.States.AddRange(new List<State>()

                    {
                   new State()
                   {
                     Name = "Slovenia",
                     FactoryName = "HBC Group",
                   },
                     new State()
                   {
                     Name = "Kosova",
                     FactoryName = "Podravka",
                   }
                   });
                    context.SaveChanges();

                }
                //Products

                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
                            {

                   new Product()
                   {
                       ProductName = "Coca Cola",
                       ImgUrl = "https://media.istockphoto.com/photos/two-liter-bottle-of-coca-cola-picture-id458709281?k=20&m=458709281&s=612x612&w=0&h=SJ1iX5WBrYdF1NOTsS2H-UMHkQm9Xzlpl4lUBcLYRlo=",
                       Description = "Coca cola description",
                       Price = 1.48f,
                       Produced = DateTime.Now.AddDays(3),
                       Expiration = DateTime.Now.AddDays(20),
                       ProductCategory = ProductCategory.Lengje,
                       StateId = 1
                   },
                   new Product()
                   {
                       ProductName = "Supe gjeli",
                       ImgUrl = "https://masliri.com/img/articles/supe-gjeli-podravka-62gr-1000835-large.jpg",
                       Description = "Supe gjeli description",
                       Price = 0.50f,
                       Produced = DateTime.Now.AddDays(3),
                       Expiration = DateTime.Now.AddDays(20),
                       ProductCategory = ProductCategory.Ushqimore,
                       StateId = 2
                   }
                    });
                        context.SaveChanges();
                }


            }
        }
    }
}
