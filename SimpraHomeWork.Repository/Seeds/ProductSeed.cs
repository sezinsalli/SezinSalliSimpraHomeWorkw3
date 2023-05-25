using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SimpraHomeWork.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHomeWork.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
            new Product
            {
                Id = 1,
                CategoryId = 1,
                Name = "Akıllı Saat",
                Price = 10000,
                Stock = 200,
                
            },
            new Product
            {
                Id = 2,
                CategoryId = 1,
                Name = "Kamera",
                Price = 20000,
                Stock = 120,
                
            },
            new Product
            {
                Id = 3,
                CategoryId = 1,
                Name = "Telefon",
                Price = 40000,
                Stock = 1200,
                
            },
            new Product
            {
                Id = 4,
                CategoryId = 2,
                Name = "ruj",
                Price = 400,
                Stock = 1200,

            }, 
            new Product
            {
                Id = 5,
                CategoryId = 2,
                Name = "Göz kalemi",
                Price = 40,
                Stock = 23200,

            },
            new Product
            {
                Id = 6,
                CategoryId = 2,
                Name = "Göz kalemi",
                Price = 40,
                Stock = 23200,

            },
            new Product
            {
                Id = 7,
                CategoryId = 3,
                Name = "Koltuk",
                Price = 40,
                Stock = 23200,

            },
            new Product
            {
                Id = 8,
                CategoryId = 1,
                Name = "Sehpa",
                Price = 40,
                Stock = 23200,

            }
            );
        }
    }
}
