using Microsoft.EntityFrameworkCore;

namespace WebTaskManager.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
        {
        }

        public DbSet<Tasks> Tarefas { get; set; }
    }
}
