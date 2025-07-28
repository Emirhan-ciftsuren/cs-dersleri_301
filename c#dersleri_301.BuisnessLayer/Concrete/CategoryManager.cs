using c_dersleri_301.BuisnessLayer.Abstract;
using c_dersleri_301.DataAccessLayer.Abstract;
using c_dersleri_301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_dersleri_301.BuisnessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }
        public void TDelete(Category entity)
        {
           _categoryDal.Delete(entity);
        }
        public List<Category> TGetAll()
        {
            return _categoryDal.GetAll();
        }
        public void TInsert(Category entity)
        {
            _categoryDal.Insert(entity);
        }
        public void TUpdate(Category entity)
        {
           _categoryDal.Update(entity);
        }
    }
}
