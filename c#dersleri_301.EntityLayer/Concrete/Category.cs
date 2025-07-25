using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_dersleri_301.EntityLayer.Concrete
{
    public class Category
    {
        int categoryId {  get; set; } // string ile tanımlı property ile aynı adı taşıması zorunlu çünkü birincil anahtar olduğunu algılaması için
      public string CategoryName { get; set; }
        public int CategoryId { get; set; }

        public bool CategpryStatus {  get; set; }
        public List<Product> Products { get; set; }
    }
}
