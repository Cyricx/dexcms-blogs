using Ninject;
using DexCMS.Blogs.Contexts;
using DexCMS.Blogs.Repositories;
using DexCMS.Blogs.Interfaces;

namespace DexCMS.Blogs.Globals
{
    public static class BlogsRegister<T> where T : IDexCMSBlogsContext
    {
        public static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IBlogRepository>().To<BlogRepository>();
            kernel.Bind<IBlogCategoryRepository>().To<BlogCategoryRepository>();
            kernel.Bind<IBlogTagRepository>().To<BlogTagRepository>();
            kernel.Bind<IBlogStatusRepository>().To<BlogStatusRepository>();
            kernel.Bind<IDexCMSBlogsContext>().To<T>();
        }
    }
}
