using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp
{
    public class AccessDbContext : DbContext
    {
        public AccessDbContext(DbContextOptions<AccessDbContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> ToDoItem { get; set; }
    }
}
