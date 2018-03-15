using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocLib.Models;
using DocLib.Domain.Interface.Repositories;

namespace DocLib.Domain.Managers
{
  public  class CartManager
    {
        private ICartRepository _cartRepository;
        private IInventoryRepository _inventoryRepository;

        public  CartManager(ICartRepository cartRepository, IInventoryRepository inventoryRepository)
        {
            _cartRepository = cartRepository;
            _inventoryRepository = inventoryRepository;
        }

        public List<ItemModel> GetCartItems()
        {
            return _cartRepository.GetCartItems();
        }

        public bool AddCartItem (int productId)
        {
            var product = _inventoryRepository.FindBook(productId);

            if (product == null) return false;

            var items = _cartRepository.GetCartItems();
            var cartItem = items.SingleOrDefault(c => c.Bookid == productId && c.Bookid == productId);
            if (cartItem == null)
            {
                items.Add(new ItemModel
                {
                    Book = product,
                    Bookid = productId,
                    Quantity = 1
                });
            }
            else
            {
                cartItem.Quantity++;
            }

            _cartRepository.SaveCartItems(items);
            return true;
        }
        public void RemoveCartItem ( int productId)
        {
            var items = _cartRepository.GetCartItems();
            var cartItem = items.Where(i => i.Bookid == productId).FirstOrDefault();
            if (cartItem == null)
            {
                cartItem.Quantity = cartItem.Quantity - 1;
                if (cartItem.Quantity >= 0) items.Remove(cartItem);
                _cartRepository.SaveCartItems(items);

            }
        }
    }
}
