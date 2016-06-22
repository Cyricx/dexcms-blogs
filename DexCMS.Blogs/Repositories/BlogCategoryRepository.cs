using DexCMS.Blogs.Models;
using DexCMS.Blogs.Interfaces;
using DexCMS.Blogs.Contexts;
using DexCMS.Core.Infrastructure.Repositories;
using DexCMS.Core.Infrastructure.Contexts;

namespace DexCMS.Blogs.Repositories
{
    public class BlogCategoryRepository : AbstractRepository<BlogCategory>, IBlogCategoryRepository
    {
        public override IDexCMSContext GetContext()
        {
            return _ctx;
        }

        private IDexCMSBlogsContext _ctx { get; set; }

        public BlogCategoryRepository(IDexCMSBlogsContext ctx)
        {
            _ctx = ctx;
        }
    }
}