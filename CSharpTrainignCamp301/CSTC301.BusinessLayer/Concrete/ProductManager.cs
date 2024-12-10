using System.Collections.Generic;
using CSTC301.EntityLayer.Concrete;
using CSTC301.BusinessLayer.Abstract;
using CSTC301.DataAccessLayer.Abstract;

namespace CSTC301.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t);
        }

        public List<Product> TGetAll()
        {
            return _productDal.GetList();
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<object> TGetProductWithCategory()
        {
            return _productDal.GetProductWithCategory();
        }

        public void TInsert(Product t)
        {
            _productDal.Insert(t);
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }
    }
}
