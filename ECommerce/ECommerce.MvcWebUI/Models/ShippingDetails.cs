using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.MvcWebUI.Models
{
    public class ShippingDetails
    {
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen adres tanımını giriniz.")]
        public string AddressTitle { get; set; }

        [Required(ErrorMessage = "Lütfen bir adres giriniz.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Lütfen şehir giriniz.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Lütfen mahalle  giriniz.")]
        public string District { get; set; }

        [Required(ErrorMessage = "Lütfen sokak giriniz.")]
        public string Street { get; set; }

        public string Postcode { get; set; }

    }
}