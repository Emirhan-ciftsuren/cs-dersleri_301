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
    public class OrderManager : IOrderService

    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public Order GetById(int id)
        {
           return _orderDal.GetById(id);
        }

        public void TDelete(Order entity)
        {
            _orderDal.Delete(entity);
        }

        public List<Order> TGetAll()
        {
         return _orderDal.GetAll();
        }

        public void TInsert(Order entity)
        {
            _orderDal.Insert(entity);
        }

        public void TUpdate(Order entity)
        {
            _orderDal.Update(entity);
        }
    }

   
}
