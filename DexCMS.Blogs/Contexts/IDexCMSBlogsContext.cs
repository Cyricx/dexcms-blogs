using System.Data.Entity;
using DexCMS.Base.Contexts;
using DexCMS.Blogs.Models;

namespace DexCMS.Blogs.Contexts
{
    public interface IDexCMSBlogsContext: IDexCMSBaseContext
    {
        DbSet<BlogCategory> BlogCategories { get; set; }
        DbSet<Blog> Blogs { get; set; }
        DbSet<BlogStatus> BlogStatuses { get; set; }
        DbSet<BlogTag> BlogTags { get; set; }
    }
}
