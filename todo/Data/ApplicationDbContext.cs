
using Microsoft.EntityFrameworkCore;
using todo.Models;

namespace todo.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<ToDo> ToDoList { get; set; }
        public DbSet<ToDoAuditLog> ToDoAudit { get; set; }


        
    }
}
