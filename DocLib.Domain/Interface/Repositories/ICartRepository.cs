using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocLib.Models;

namespace DocLib.Domain.Interface.Repositories
{
    public interface ICartRepository
    {
        List<ItemModel> GetCartItems();
        void SaveCartItems(List<ItemModel> items);
    }
}
