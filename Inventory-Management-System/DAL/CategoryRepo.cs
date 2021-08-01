using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryRepo
    {
        static InventoryMSEntities context;
        static CategoryRepo()
        {
            context = new InventoryMSEntities();
        }

        public static List<string> GetCategoryNames()
        {
            var data = context.inra_bd_categories.Select(e => e.name).ToList();
            return data;
        }

        public static List<inra_bd_categories> GetCategories()
        {
            return context.inra_bd_categories.ToList();
        }

        public static void AddCategory(inra_bd_categories d)
        {
            context.inra_bd_categories.Add(d);
            context.SaveChanges();
        }

        public static inra_bd_categories GetCategoryDetail(int id)
        {
            return context.inra_bd_categories.FirstOrDefault(e => e.id == id);
        }
    }
}
