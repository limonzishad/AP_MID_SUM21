using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    class CategoryDetail
    {
        public int id { get; set; }
        public string name { get; set; }

        public virtual ICollection<ProductModel> Products { get; set; }
    }
}
