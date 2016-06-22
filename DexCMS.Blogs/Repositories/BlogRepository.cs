using DexCMS.Core.Infrastructure.Repositories;
using DexCMS.Blogs.Models;
using DexCMS.Blogs.Interfaces;
using DexCMS.Core.Infrastructure.Contexts;
using DexCMS.Blogs.Contexts;

namespace DexCMS.Blogs.Repositories
{
    public class BlogRepository : AbstractRepository<Blog>, IBlogRepository
    {
        public override IDexCMSContext GetContext()
        {
            return _ctx;
        }

        private IDexCMSBlogsContext _ctx { get; set; }

        public BlogRepository(IDexCMSBlogsContext ctx)
        {
            _ctx = ctx;
        }
    }
}