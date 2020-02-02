using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ECommerce.MvcWebUI.Entity
{
    public class Product
    {

        public int Id { get; set; }

        [DisplayName("Ürün Adı")]
        public string Name { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }

        [DisplayName("Fiyat")]
        public double Price { get; set; }

        [DisplayName("Adet")]
        public int Stock { get; set; }

        [DisplayName("Resim")]
        public string Image { get; set; }

        [DisplayName("AnasayfadaMı")]
        public bool IsHome { get; set; }

        [DisplayName("OnaylıMı")]
        public bool IsApproved { get; set; }

        [DisplayName("Kategori")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}