using System.Collections.Generic;
using CSTC301.EntityLayer.Concrete;

namespace CSTC301.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<object> GetProductWithCategory();
    }
}
