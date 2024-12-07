using System.Collections.Generic;
using CSTC301.EntityLayer.Concrete;
using CSTC301.BusinessLayer.Abstract;
using CSTC301.DataAccessLayer.Abstract;

namespace CSTC301.BusinessLayer.Concrete
{
    internal class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void TDelete(Order t)
        {
            _orderDal.Delete(t);
        }

        public List<Order> TGetAll()
        {
            return _orderDal.GetList();
        }

        public Order TGetById(int id)
        {
            return _orderDal.GetById(id);
        }

        public void TInsert(Order t)
        {
            _orderDal.Insert(t);
        }

        public void TUpdate(Order t)
        {
            _orderDal.Update(t);
        }
    }
}
