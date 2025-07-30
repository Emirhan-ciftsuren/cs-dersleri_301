using c_dersleri_301.DataAccessLayer.Abstract;
using c_dersleri_301.DataAccessLayer.Context;
using c_dersleri_301.DataAccessLayer.Repositories;
using c_dersleri_301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_dersleri_301.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<object> GetProductWithCategory()
        {
            var context = new CampContext();
            var values = context.Products
                .Select(x => new 
                {
                    ProductId = x.ProductId,
                    ProductName= x.ProductName,
                    ProductStock= x.ProductStock,
                    ProductPrice= x.ProductPrice,
                    ProductDescription= x.ProductDescription,
                    CategoryName = x.Category.CategoryName
                }).ToList();
            return values.Cast<object>().ToList();
        }
    }
}
