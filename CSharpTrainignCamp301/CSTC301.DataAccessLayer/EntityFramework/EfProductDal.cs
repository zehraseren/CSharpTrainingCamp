using System.Linq;
using System.Collections.Generic;
using CSTC301.EntityLayer.Concrete;
using CSTC301.DataAccessLayer.Context;
using CSTC301.DataAccessLayer.Abstract;
using CSTC301.DataAccessLayer.Repositories;

namespace CSTC301.DataAccessLayer.EntityFramework
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
                    ProductName = x.ProductName,
                    ProductStock = x.ProductStock,
                    ProductPrice = x.ProductPrice,
                    ProductDescription = x.ProductDescription,
                    CategoryName = x.Category.CategoryName,
                }).ToList();
            return values.Cast<object>().ToList();
        }
    }
}
