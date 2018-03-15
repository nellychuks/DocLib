using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocLib.Models;

namespace DocLib.Domain.Interface.Repositories
{
    public interface IInventoryRepository
    {
        BookModel[] GetBooks();
        BookModel FindBook(int id);
        BookModel[] FindBook(string search);
    }
}
