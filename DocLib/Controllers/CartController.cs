using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DocLib.Data;
using DocLib.Data.Repositories;
using DocLib.Domain.Managers;
using DocLib.Utils;
using System.Web.Mvc;

namespace DocLib.Controllers
{
    public class CartController : Controller
    {
        private DataContext _context;
        private CartManager _cartManager;

        public CartController()
        {
            _context = new DataContext();
            var cartRepository = new SessionRepository();
            var inventoryRepository = new InventoryRepository(_context);
            _cartManager = new CartManager(cartRepository, inventoryRepository);
        }

            public ActionResult Index()
        {
            var items = _cartManager.GetCartItems();
            return View(items);
        }

        public ActionResult Add(int id = 0)
        {
            _cartManager.AddCartItem(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}