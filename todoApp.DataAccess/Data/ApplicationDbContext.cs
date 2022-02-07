
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using todoApp.Models;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace todoApp.DataAccess
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
        }

        public virtual Microsoft.EntityFrameworkCore.DbSet<User> User { get; set; }
        public virtual Microsoft.EntityFrameworkCore.DbSet<ToDo> ToDo { get; set; }
        public virtual Microsoft.EntityFrameworkCore.DbSet<ToDoAuditLog> ToDoAuditLog { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<ToDoAuditLog>()
                .HasOne(e => e.User)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
        }


    }
}
