using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocLib.Domain.Interface.Repositories;
using DocLib.Models;

namespace DocLib.Data.Repositories
{
 public   class InventoryRepository : IInventoryRepository
    {
        private DataContext _context;
        public InventoryRepository(DataContext context)
        {
            _context = context;
        }
          
        public BookModel[] FindBook(string search)
        {
            var query = from book in _context.Books
                        where book.Name.Contains(search)
                        || book.Description.Contains(search)
                        || book.Category.Contains(search)
                        select new BookModel
                        {
                            Price = book.Price,
                            Category = book.Category,
                            Desription = book.Description,
                            Name = book.Name,
                            Bookid = book.Bookid,
                            Publication = book.Publication,
                            Author = book.Author

                        };
            return query.ToArray();
        }

        public BookModel FindBook(int id)
        {
            var query = from book in _context.Books
                        where book.Bookid == id
                        select new BookModel
                        {
                            Price = book.Price,
                            Category = book.Category,
                            Desription = book.Description,
                            Name = book.Name,
                            Bookid = book.Bookid,
                            Publication = book.Publication,
                            Author = book.Author
                        };
            return query.FirstOrDefault();
        }

        public BookModel[] GetBooks()
        {
            var query = from book in _context.Books
                        select new BookModel
                        {
                            Price = book.Price,
                            Category = book.Category,
                            Desription = book.Description,
                            Name = book.Name,
                            Bookid = book.Bookid,
                            Publication = book.Publication,
                            Author = book.Author
                        };
            return query.ToArray();
        }
    }
}
