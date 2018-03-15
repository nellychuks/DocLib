using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DocLib.Domain.Managers;
using DocLib.Data.Repositories;
using DocLib.Data;
using System.Web.Mvc;

namespace DocLib.Controllers
{
    public class HomeController : Controller
    {
        private InventoryManager _inventorryManager;
        private DataContext _context;

        public HomeController()
        {
            _context = new DataContext();
            var repository = new InventoryRepository(_context);
            _inventorryManager = new InventoryManager(repository);
        }

        public ActionResult Index(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                var books = _inventorryManager.GetBooks();
                return View(books);
            }
            else
            {
                var books = _inventorryManager.Find(search);
                return View(books);
            }

        }
        protected override void Dispose(bool disposing)
        {
           
            _context.Dispose();
        }
    }
}