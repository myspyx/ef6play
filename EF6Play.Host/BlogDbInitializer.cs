using System.Data.Entity;

namespace EF6Play.Host
{
    public class BlogDbInitializer : CreateDatabaseIfNotExists<BlogDbContext>
    {
        protected override void Seed(BlogDbContext context)
        {
            base.Seed(context);
            context.Blogs.Add(new Blog
            {
                Name = "Hello",
                BlogId = 1,
                Author = "LLIB"
            });
        }
    }
}