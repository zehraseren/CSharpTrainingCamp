using System.Collections.Generic;
using CSTC301.EntityLayer.Concrete;

namespace CSTC301.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<object> TGetProductWithCategory();
    }
}
