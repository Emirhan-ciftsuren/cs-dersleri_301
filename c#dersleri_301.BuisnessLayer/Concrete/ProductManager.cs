using c_dersleri_301.BuisnessLayer.Abstract;
using c_dersleri_301.DataAccessLayer.Abstract;
using c_dersleri_301.DataAccessLayer.EntityFramework;
using c_dersleri_301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_dersleri_301.BuisnessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly  IProductDal  _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void TDelete(Product entity)
        {
           _productDal.Delete(entity);
        }

        public List<Product> TGetAll()
        {
           return _productDal.GetAll();
        }

        public List<object> TGetProductWithCategory()
        {
            return _productDal.GetProductWithCategory   ();
        }

        public void TInsert(Product entity)
        {
            _productDal.Insert(entity);
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
