using Microsoft.EntityFrameworkCore;
using TodoApplication.Models;

namespace TodoApplication.DataAccess {
    public class DContext : DbContext{
        public DbSet<Todo> todos { get; set; }
        public DbSet<ApplicationUser> users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Server=localhost; Database=todoapp; persist security info=True; Integrated Security = SSPI;");
        }
        override protected void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Todo>().HasData(
                    new Todo { Id = 1, Title = "Test1", Description = "Testing description", UserId = 1 },
                    new Todo { Id = 2, Title = "Test2", Description = "Testing description 2", UserId = 1 },
                    new Todo { Id = 3, Title = "Test3", Description = "Testing description 3", UserId = 3 }
                );
            modelBuilder.Entity<ApplicationUser>().HasData(
                    new ApplicationUser { Id = 1,Name = "Sandun", AddressNo = "162/4", Street = "Anderson", City = "Ambalangoda"},
                    new ApplicationUser { Id = 2, Name = "Pushpika", AddressNo = "162/4", Street = "Anderson", City = "Ambalangoda" },
                    new ApplicationUser { Id = 3, Name = "Jenny", AddressNo = "32B/7", Street = "Calabasa", City = "California" }
                );
        }
    }
}
