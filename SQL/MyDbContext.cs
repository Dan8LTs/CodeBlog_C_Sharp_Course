using System.Data.Entity;

namespace SQL
{
    internal class MyDbContext : DbContext
    {
        public MyDbContext() : base("DbConnectionString") { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Picture> Pictures { get; set; }
    }
}
