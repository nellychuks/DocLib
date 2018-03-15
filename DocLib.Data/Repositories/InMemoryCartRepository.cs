using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocLib.Domain.Interface.Repositories;
using DocLib.Models;

namespace DocLib.Data.Repositories
{
   public class InMemoryCartRepository : ICartRepository
    {
        private List<ItemModel> _items = new List<ItemModel>();

        public List<ItemModel> GetCartItems()
        {
            return _items;
        }

        public void SaveCartItems(List<ItemModel> items)
        {
            _items = items;
        }
    }
}
