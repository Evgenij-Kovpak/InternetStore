using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyOnlineStore.Models;

namespace MyOnlineStore.Infrastructure
{
    public class MyOnlineStoreContext : IdentityDbContext<AppUser>
    {
        public MyOnlineStoreContext(DbContextOptions<MyOnlineStoreContext> options)
            : base(options)
        {
        }

        public DbSet<Page> Pages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
