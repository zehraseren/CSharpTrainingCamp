using System.Collections.Generic;
using CSTC301.EntityLayer.Concrete;
using CSTC301.BusinessLayer.Abstract;
using CSTC301.DataAccessLayer.Abstract;

namespace CSTC301.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TDelete(Customer t)
        {
            _customerDal.Delete(t);
        }

        public List<Customer> TGetAll()
        {
            return _customerDal.GetList();
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public void TInsert(Customer t)
        {
            if (t.CustomerName != "" && t.CustomerName.Length >= 3 && t.CustomerCity != null && t.CustomerSurname != "" && t.CustomerName.Length <= 30)
            {
                _customerDal.Insert(t);
            }
            else
            {
                // Hata mesajı
            }
        }

        public void TUpdate(Customer t)
        {
            if (t.CustomerId != 0 && t.CustomerCity.Length >= 3)
            {
                _customerDal.Update(t);
            }
            else
            {
                // Hata mesajI
            }
        }
    }
}
