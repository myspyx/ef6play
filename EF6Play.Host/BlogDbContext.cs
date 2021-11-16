using System.Data.Entity;

namespace EF6Play.Host
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(): base("BlogDbContext")
        {
            
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .HasMany(b => b.Posts)
                .WithRequired(p => p.Blog);
            
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}