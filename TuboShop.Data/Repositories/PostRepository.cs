using System.Collections;
using System.Collections.Generic;
using TuboShop.Data.Infrastructure;
using TuboShop.Model.Models;
using System.Linq;

namespace TuboShop.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow);
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow)
        {
            var query = from p in DbContext.Posts //join 2 bang de lay theo tag
                        join pt in DbContext.PostTags
                        on p.ID equals pt.PostID
                        where pt.TagID == tag && p.Status
                        orderby p.CreatedDate descending
                        select p;
            totalRow = query.Count(); //dem, thuc thi va tra ve ban ghi, phan trang
            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize); //tang ban ghi
            return query;
        }
    }
}
