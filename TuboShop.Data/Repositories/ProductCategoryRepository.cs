using System.Collections.Generic;
using TuboShop.Data.Infrastructure;
using TuboShop.Model.Models;
using System.Linq;

namespace TuboShop.Data.Repositories
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory): base(dbFactory) //nhan tham so truyen vao giong RepositoryBase
        {

        }

        public IEnumerable<ProductCategory> GetByAlias(string alias) //tu dinh nghia vi khong nam trong tap phuong thuc co san cua RepositoryBase
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}