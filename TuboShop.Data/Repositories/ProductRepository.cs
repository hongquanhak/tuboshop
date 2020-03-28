using TuboShop.Data.Infrastructure;
using TuboShop.Model.Models;

namespace TuboShop.Data.Repositories
{
    public interface IProductRepository
    {
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        //ke thua constructor
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}