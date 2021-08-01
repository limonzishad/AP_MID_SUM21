using BEL;
using BLL.MapperConfig;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoryService
    {
        public static List<string> GetCategoryName()
        {
            return CategoryRepo.GetCategoryNames();
        }

        public static List<CategoryModel> GetCategories()
        {
            var categories = CategoryRepo.GetCategories();
            var data = AutoMapper.Mapper.Map<List<inra_bd_categories>, List<CategoryModel>>(categories);
            return data;
        }

        public static void AddCategory(CategoryModel cat)
        {
            var d = AutoMapper.Mapper.Map<CategoryModel, inra_bd_categories>(cat);
            CategoryRepo.AddCategory(d);
        }

        public static CategoryDetail GetCategoryDetail(int id)
        {
            var d = CategoryRepo.GetCategoryDetail(id);
            var deptdetail = AutoMapper.Mapper.Map<inra_bd_categories, CategoryDetail>(d);
            return deptdetail;
        }

        public static List<CategoryDetail> GetCategoryDetails()
        {
            var data = CategoryRepo.GetCategories();
            var dDetails = AutoMapper.Mapper.Map<List<inra_bd_categories>, List<CategoryDetail>>(data);
            return dDetails;

        }
    }
}
