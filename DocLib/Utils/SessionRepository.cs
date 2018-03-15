using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DocLib.Domain.Interface.Repositories;
using DocLib.Models;

namespace DocLib.Utils
{
    public class SessionRepository : ICartRepository
    {
        public List<ItemModel> GetCartItems()
        {
            var cartItems = HttpContext.Current.Session["Cart"] as List<ItemModel>;
            if (cartItems == null)
            {
                cartItems = new List<ItemModel>();
                HttpContext.Current.Session["Cart"] = cartItems;
            }
            return cartItems;
        }

        public void SaveCartItems(List<ItemModel> items)
        {
            if (items == null) throw new ArgumentNullException("Items cannot be null");
            HttpContext.Current.Session["Cart"] = items;
        }
    }
}