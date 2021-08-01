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
    public class ProductService
    {
        public static void AddProduct(ProductModel model)
        {
            var data = AutoMapper.Mapper.Map<ProductModel, inra_bd_products>(model);
            ProductRepo.AddProduct(data);
        }
        public static ProductModel GetProduct(int id)
        {
            var data = ProductRepo.GetProduct(id);
            var st = AutoMapper.Mapper.Map<inra_bd_products, ProductModel>(data);
            return st;
        }
        public static List<ProductModel> GetAllProducts()
        {
            var data = ProductRepo.GetAllProducts();
            var st = AutoMapper.Mapper.Map<List<inra_bd_products>, List<ProductModel>>(data);
            return st;
        }

        public static List<string> GetProductNames()
        {
            throw new NotImplementedException();
        }

        public static List<string> GetStudentNames()
        {
            var data = ProductRepo.GetProductNames();
            return data;
        }
    }
}
