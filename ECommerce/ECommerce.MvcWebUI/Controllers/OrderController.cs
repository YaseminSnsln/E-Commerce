using ECommerce.MvcWebUI.Entity;
using ECommerce.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.MvcWebUI.Controllers
{
    [Authorize(Roles = "admin")]
    public class OrderController : Controller
    {

        private readonly DataContext db = new DataContext();
        // GET: Order
        public ActionResult Index()
        {

            var orders = db.Orders.Select(i => new AdminOrderModel()
            {
                Id = i.Id,
                OrderNumber = i.OrderNumber,
                Total = i.Total,
                OrderDate = i.OrderDate,
                OrderState = i.OrderState,
                Count = i.Orderlines.Count
            }).OrderByDescending(i => i.OrderDate).ToList();

            return View(orders);
        }
        public ActionResult Details(int id)
        {
            var entity = db.Orders
                .Where(i => i.Id == id)
                .Select(i => new OrderDetailsModel()
                {
                    OrderId = i.Id,
                    Username = i.Username,
                    OrderNumber = i.OrderNumber,
                    Total = i.Total,
                    OrderDate = i.OrderDate,
                    OrderState = i.OrderState,
                    AddressTitle = i.AddressTitle,
                    Address = i.Address,
                    City = i.City,
                    District = i.District,
                    Street = i.Street,
                    Postcode = i.Postcode,
                    Orderlines = i.Orderlines.Select(a => new OrderLineModel()
                    {
                        ProductId = a.ProductId,
                        ProductName = a.Product.Name.Length > 50 ? a.Product.Name.Substring(0, 47) + "..." : a.Product.Name,
                        Image = a.Product.Image,
                        Quantity = a.Quantity,
                        Price = a.Price

                    }).ToList()
                })
                .FirstOrDefault();

            return View(entity);
        }
        public ActionResult UpdateOrderState(int orderId, EnumOrderState orderState)
        {
            var order = db.Orders.FirstOrDefault(i => i.Id == orderId);
            if (order != null)
            {
                order.OrderState = orderState;
                db.SaveChanges();

                TempData["message"] = "Bilgileriniz Kayıt Edildi.";
                return RedirectToAction("Details", new { id = orderId});
            }
            return RedirectToAction("Index");
        }
    }
}