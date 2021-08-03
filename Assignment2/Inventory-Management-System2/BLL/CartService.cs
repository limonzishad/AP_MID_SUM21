using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CartService
    {
        public static List<CartModel> GetCarts()
        {
            var orders = CartRepo.GetCarts();
            var data = AutoMapper.Mapper.Map<List<CartTable>, List<CartModel>>(orders);
            return data;
        }
        public static void AddToCart(ProductModel e)
        {
            var pro = new CartModel();

            pro.ProductId = e.Id;
            pro.ProductName = e.Name;
            pro.Price = e.Price;
            pro.Qty = 1;
            pro.TotalPrice = e.Price;

            var d = AutoMapper.Mapper.Map<CartModel, CartTable>(pro);
            CartRepo.AddToCart(d);
        }
    }
}