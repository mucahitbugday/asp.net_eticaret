using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Eticaret_02.MvcWebUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {

        protected override void Seed(DataContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category(){Name = "Kamera", Description = "Kamera Ürünleri"},

                new Category(){Name = "Telefon", Description = "Telefon Ürünleri"},

                new Category(){Name = "Bilgisayar", Description = "Bilgisayar Ürünleri"},

                new Category(){Name = "Beyaz Eşya", Description = "Beyaz Eşya Ürünleri"},

            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();


            List<Product> urunler = new List<Product>()
            {
                new Product(){Name="Ürün 1", Description="Durumu sıfır kat. 1", StocCode="TK-C-200", Star=5, PriceOld=1000.0, PriceNew=799.0, Stock=10, IsApproved = true, CategoryId= 1,IsHome=true,ImageSmall="https://dummyimage.com/450x300/dee2e6/6c757d.jpg",ImageLarge="https://dummyimage.com/600x700/dee2e6/6c757d.jpg"},
                new Product(){Name="Ürün 2", Description="Durumu sıfır kat. 1", StocCode="TK-C-200", Star=2, PriceOld=1000.0, PriceNew=899.0, Stock=10, IsApproved = true, CategoryId= 1,IsHome=false,ImageSmall="https://dummyimage.com/450x300/dee2e6/6c757d.jpg",ImageLarge="https://dummyimage.com/600x700/dee2e6/6c757d.jpg"},
                new Product(){Name="Ürün 3", Description="Durumu sıfır kat. 1", StocCode="TK-C-200", Star=3, PriceOld=1000.0, PriceNew=999.0, Stock=10, IsApproved = true, CategoryId= 1,IsHome=false,ImageSmall="https://dummyimage.com/450x300/dee2e6/6c757d.jpg",ImageLarge="https://dummyimage.com/600x700/dee2e6/6c757d.jpg"},

                new Product(){Name="Ürün 4", Description="Durumu sıfır kat. 2", StocCode="TK-C-200", Star=4, PriceOld=1000.0, PriceNew=699.0, Stock=10, IsApproved = true, CategoryId= 2,IsHome=true,ImageSmall="https://dummyimage.com/450x300/dee2e6/6c757d.jpg",ImageLarge="https://dummyimage.com/600x700/dee2e6/6c757d.jpg"},
                new Product(){Name="Ürün 5", Description="Durumu sıfır kat. 2", StocCode="TK-C-200", Star=2, PriceOld=1000.0, PriceNew=699.0, Stock=10, IsApproved = true, CategoryId= 2,IsHome=false,ImageSmall="https://dummyimage.com/450x300/dee2e6/6c757d.jpg",ImageLarge="https://dummyimage.com/600x700/dee2e6/6c757d.jpg"},
                new Product(){Name="Ürün 6", Description="Durumu sıfır kat. 2", StocCode="TK-C-200", Star=5, PriceOld=1000.0, PriceNew=699.0, Stock=10, IsApproved = true, CategoryId= 2,IsHome=false,ImageSmall="https://dummyimage.com/450x300/dee2e6/6c757d.jpg",ImageLarge="https://dummyimage.com/600x700/dee2e6/6c757d.jpg"},

                new Product(){Name="Ürün 7", Description="Durumu sıfır kat. 3", StocCode="TK-C-200", Star=3, PriceOld=1000.0, PriceNew=699.0, Stock=10, IsApproved = true, CategoryId= 3,IsHome=true,ImageSmall="https://dummyimage.com/450x300/dee2e6/6c757d.jpg",ImageLarge="https://dummyimage.com/600x700/dee2e6/6c757d.jpg"},
                new Product(){Name="Ürün 8", Description="Durumu sıfır kat. 3", StocCode="TK-C-200", Star=4, PriceOld=1000.0, PriceNew=699.0, Stock=10, IsApproved = true, CategoryId= 3,IsHome=true,ImageSmall="https://dummyimage.com/450x300/dee2e6/6c757d.jpg",ImageLarge="https://dummyimage.com/600x700/dee2e6/6c757d.jpg"},
                new Product(){Name="Ürün 9", Description="Durumu sıfır kat. 3", StocCode="TK-C-200", Star=5, PriceOld=1000.0, PriceNew=699.0, Stock=10, IsApproved = true, CategoryId= 3,IsHome=false,ImageSmall="https://dummyimage.com/450x300/dee2e6/6c757d.jpg",ImageLarge="https://dummyimage.com/600x700/dee2e6/6c757d.jpg"},
            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();




            base.Seed(context);
        }

    }
}