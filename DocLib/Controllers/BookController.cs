using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DocLib.Data;
using DocLib.Data.Repositories;
using DocLib.Domain.Managers;
using System.Web.Mvc;

namespace DocLib.Controllers
{
    public class BookController : Controller 
    {
        private InventoryManager _inventory;
        private DataContext _context;

        public BookController()
        {
            _context = new DataContext();
            var inventoryRepository = new InventoryRepository(_context);
            _inventory = new InventoryManager(inventoryRepository);
        }

        public ActionResult Detail (int id = 0)
        {
            var book = _inventory.FindBook(id);
            return View(book);
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}