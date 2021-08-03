using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CartRepo
    {
        static InventoryMS2Entities context;
        static CartRepo()
        {
            context = new InventoryMS2Entities();
        }

        public static List<CartTable> GetCarts()
        {
            return context.CartTables.ToList();
        }

        public static void AddToCart(CartTable d)
        {
            context.CartTables.Add(d);
            context.SaveChanges();
        }

        public static void CleanCart()
        {
            var cart = GetCarts();
            foreach (var d in cart)
            {
                context.CartTables.Remove(d);
                context.SaveChanges();
            }
        }

        public static CartTable GetCartItem(int id)
        {
            return context.CartTables.FirstOrDefault(e => e.Id == id);
        }

        public static void DeleteCartItem(int id)
        {
            var d = GetCartItem(id);
            context.CartTables.Remove(d);
            context.SaveChanges();
        }
    }
}