using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MapperConfig
{
    public class AutoMapperSettings : Profile
    {
        public AutoMapperSettings()
        {
            CreateMap<CategoryModel, inra_bd_categories>().ForMember(e => e.inra_bd_products, d => d.Ignore());
            CreateMap<inra_bd_categories, CategoryDetail>();
            CreateMap<ProductModel, inra_bd_products>().ForMember(e => e.inra_bd_categories, sm => sm.Ignore());
        }
    }
}
