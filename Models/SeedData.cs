using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Collections.Generic;

namespace MakeupProject.Models
{
    public static class SeedData
    {
         public static void Initialize(IServiceProvider serviceProvider)
         {
             using (var context = new MakeupProjectDbContext(
                 serviceProvider.GetRequiredService<
                     DbContextOptions<MakeupProjectDbContext>>()))
                     {
                         if(context.Product.Any())
                         {
                             return; 
                         }

                         context.Product.AddRange(
                             new Products
                             {
                                Brand = "Urban Decay",
                                Name = "All nighter Makeup Setting Spray",
                                Price = 32.00M,
                                BuyAt = "Sephora, Ulta",
                                Type = "Face", 
                                Reviews = new List<Review> 
                                {
                                    new Review {Stars = 4, ReviewText = "This product will make your foundation last for 24 hours atleast!"},
                                    new Review {Stars = 5, ReviewText = "I use my setting spray everyday, I couldn't finish my look without it"}
                                 }

                             }, 
                             new Products
                             {
                                 Brand = "Urban Decay",
                                 Name = "Eyeshadow Primer Potion",
                                 Price = 21.00M, 
                                 BuyAt = "Sephora, Ulta",
                                 Type = "Eyes",
                                 Reviews = new List<Review>
                                {
                                      new Review {Stars = 3, ReviewText = "I really like this product however, I wish it would dry down faster."},
                                      new Review {Stars = 5, ReviewText = "This is the best primer I have ever had! Makes my eyeshadow so vibrant and doesn't fade all day."},
                                      new Review {Stars = 5}
                                 }
                             },
                             new Products
                             {
                                 Brand = "Milani",
                                 Name = "Amore Matte Lip Creme",
                                 Price = 8.99M, 
                                 Type = "Lips",
                                 BuyAt = "Walmart",
                                 Reviews = new List<Review>
                                 {
                                    new Review {Stars = 4, ReviewText = "This is the best drug store liquid lipstick I've ever used! Just a little drying but if you put chapstick first it's perfect"}         
                                 }

                             },
                             new Products 
                             {
                                 Brand = "Maybelline",
                                 Name = "Instant Age Rewind Eraser Dark Circle Treatment Concealer",
                                 Price = 9.99M,
                                 Type = "Face",
                                 BuyAt = "Walmart, Target",
                                 Reviews = new List<Review>
                                  {
                                      new Review{Stars = 5}
                                  }

                             }

                         );
                         context.SaveChanges();
                     }
         }
    }
}