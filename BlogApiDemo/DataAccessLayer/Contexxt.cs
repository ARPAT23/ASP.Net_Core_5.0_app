using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
    public class Contexxt:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=LAPTOP-OA65NA35\\SQLEXPRESS;database=CoreBlogApiDb;integrated security=true;Encrypt=false");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
