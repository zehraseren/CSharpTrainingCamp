using CSTC301.EntityLayer.Concrete;
using CSTC301.DataAccessLayer.Abstract;
using CSTC301.DataAccessLayer.Repositories;

namespace CSTC301.DataAccessLayer.EntityFramework
{
    public class EfOrderDal : GenericRepository<Order>, IOrderDal
    {
    }
}
