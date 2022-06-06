using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stajrapor.Entity
{
    public class DataIntilializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
               new Category(){Name="Kırtasiye", Description="KIRTASİYE ÜRÜNLERİ"},
               new Category(){Name="Temizlik Malzemeleri", Description="TEMİZLİK ÜRÜNLERİ"},
               new Category(){Name="BT Ürünleri", Description="TEKNOLOJİK ALETLER"}
            };
            foreach (var kategori in kategoriler)
            {
                context.Categoris.Add(kategori);

            }
            context.SaveChanges();

           // Create list product
            var urunler = new List<Product>()
            {
                new Product(){Name="A4 Kağıdı", Description="kırtasiye ürünleri", price=150, Stock=20,IsHome=true, IsApproved=true, IsFeatured=true,Slider=true,CategoryId=1,Image="1.jpg" },
            new Product(){Name="Toner", Description="bt ürünleri", price=670, Stock=5,IsHome=true, IsApproved=true, IsFeatured=true,Slider=true,CategoryId=1,Image="2.jpg" }

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