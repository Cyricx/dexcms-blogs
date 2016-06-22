using DexCMS.Core.Infrastructure.Repositories;
using DexCMS.Blogs.Models;
using DexCMS.Blogs.Interfaces;
using DexCMS.Core.Infrastructure.Contexts;
using DexCMS.Blogs.Contexts;

namespace DexCMS.Blogs.Repositories
{
    public class BlogStatusRepository : AbstractRepository<BlogStatus>, IBlogStatusRepository
    {
        public override IDexCMSContext GetContext()
        {
            return _ctx;
        }

        private IDexCMSBlogsContext _ctx { get; set; }

        public BlogStatusRepository(IDexCMSBlogsContext ctx)
        {
            _ctx = ctx;
        }
    }
}