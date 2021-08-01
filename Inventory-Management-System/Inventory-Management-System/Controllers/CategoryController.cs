using System;
using BEL;
using BLL;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Inventory_Management_System.Controllers
{
    public class CategoryController : ApiController
    {
        [Route("api/Category/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return CategoryService.GetCategoryName();
        }
        
        [Route("api/Category/GetAll")]
        [HttpGet]
        public List<CategoryModel> GetAllCategory()
        {
            return CategoryService.GetCategories();
        }
        
        [Route("api/Category/Add")]
        [HttpPost]
        public void Add(CategoryModel cat)
        {
            CategoryService.AddCategory(cat);
        }
       
        [Route("api/Category/All/Details")]
        public List<CategoryDetail> GetCategoryDetails()
        {
            return CategoryService.GetCategoryDetails();
        }
        
        [Route("api/Category/{id}/Details")]
        public CategoryDetail GetCategoryDetails(int id)
        {
            return CategoryService.GetCategoryDetail(id);
        }
    }
}
