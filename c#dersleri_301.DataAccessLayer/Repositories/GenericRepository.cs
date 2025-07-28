using c_dersleri_301.DataAccessLayer.Abstract;
using c_dersleri_301.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_dersleri_301.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        CampContext context = new CampContext();
       private readonly DbSet<T> _object;
        public GenericRepository()
        {
            _object=context.Set<T>();
        }

        public void Delete(T entity)
        {
          var deletedEntity=context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
           return _object.ToList();
        }

        public T GetById(int id)
        {
            return (T)_object.Find(id);
        }

        public void Insert(T entity)
        {
            var addedEntity=context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
           var updatedEntity=context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
