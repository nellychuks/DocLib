using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocLib.Models;
using DocLib.Domain.Interface.Repositories;

namespace DocLib.Domain.Managers
{
   public class InventoryManager
    {
        private IInventoryRepository _inventory;

        public InventoryManager (IInventoryRepository inventory)
        {
            _inventory = inventory;
        }

        public BookModel FindBook(int id)
        {
            return _inventory.FindBook(id);
        }

        public List<BookModel> GetBooks()
        {
            var book = _inventory.GetBooks();
            return book.ToList();
        }

        public List<BookModel> Find(string search)
        {
            var books = _inventory.FindBook(search);
            return books.ToList();
        }
    }
}
