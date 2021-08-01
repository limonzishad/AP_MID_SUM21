using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductRepo
    {
        static InventoryMSEntities context;
        static ProductRepo()
        {
            context = new InventoryMSEntities();
        }

        public static void AddProduct(inra_bd_products model)
        {
            context.inra_bd_products.Add(model);
            context.SaveChanges();
        }

        public static List<inra_bd_products> GetAllProducts()
        {
            var data = context.inra_bd_products.ToList();
            return data;
        }

        public static inra_bd_products GetProduct(int id)
        {
            var data = context.inra_bd_products.FirstOrDefault(e => e.id == id);
            return data;
        }

        public static List<string> GetProductNames()
        {
            var data = context.inra_bd_products.Select(e => e.name).ToList();
            return data;
        }
    }
}
