using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ECommerce.MvcWebUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var categories = new List<Category>()
            {
                new Category(){Name = "Bilgisayar", Description = "Bilgisayar Ürünleri"},
                new Category(){Name = "Telefon", Description = "Telefon Ürünleri"},
                new Category(){Name = "Elektronik", Description = "Elektronik Ürünleri"},
                new Category(){Name = "Beyaz Eşya", Description = "Beyaz Eşya Ürünleri"}
            };

            foreach (var category in categories)
            {
                context.Categories.Add(category);
            }
            context.SaveChanges();

            var products = new List<Product>()
            {
                new Product(){Name = "Asus FX705DU-AU037 Laptop", Description = "Asus FX705DU-AU037 AMD Ryzen 7 3750H 8GB 1TB + 128GB SSD GTX1660Ti Freedos 17.3'' FHD", Price = 7500, Stock = 50, Image = "asus.jpg", IsHome = true, IsApproved = true, CategoryId = 1},
                new Product(){Name = "Lenovo V330-15IKB Laptop", Description = " Intel Core i5 8250U 8GB 1TB + 128GB SSD Radeon 530 Freedos 15.6'' FHD Taşınabilir Bilgisayar 81AX00Q6TX", Price = 3500, Stock = 40, Image = "lenovo.jpg", IsHome = true, IsApproved = true, CategoryId = 1},
                new Product(){Name = "Samsung Galaxy M20 32 GB", Description = "Yeni nesil teknolojilerle donatılmış Samsung Galaxy M20 32 GB modelleri güçlü batarya kapasitesi, sonsuz ekranı, açılı çift kamerası ve daha fazlasıyla kullanıcıların ilgisini ve beğenisini topluyor. Yeni M serisi akıllı telefonlardan olan M20, hafıza kapasitesiyle de göz dolduruyor. Tüm dosya ve belgelerinizi depolayabilmenize olanak tanımasının yanı sıra 5000 mAh batarya gücü ile de sizi yarı yolda bırakmayan ürün, hızlı şarj özelliği sayesinde de öne çıkıyor. Ultra geniş açılı kamera sayesinde sıra dışı fotoğraflar ve videolar yakalamanıza imkan veren M20 32 GB, parmak izi tarama sistemiyle de güvenliğinizi artırmayı başarıyor. Samsung Galaxy M20 32 GB akıllı telefon, diğer tüm teknolojileri ile akıllı telefonlar arasında üst sıralarda yer almayı başarıyor.", Price = 1500, Stock = 200, Image = "samsung.jpg", IsHome = false, IsApproved = false, CategoryId = 2},
                new Product(){Name = "Oppo A5s 32 GB", Description = "Oppo A5s 32 GB modelleri, şık ve modern tasarımının yanı sıra gelişmiş kamera performansı ile ön plana çıkıyor. Oppo A5s'in üstün kamera teknolojisi, çektiği fotoğrafları sosyal medyada sevdikleriyle paylaşmak isteyen kullanıcılar için kaliteli bir deneyim sunuyor. Ayrıca telefonun damla çentiğe sahip geniş HD+ ekranı, yüksek kapasiteli bataryası ve başarılı tasarımı her türlü kullanım koşulunda beklentileri fazlasıyla karşılıyor.", Price = 1200, Stock = 100, Image = "oppo.jpg", IsHome = true, IsApproved = true, CategoryId = 2}
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}