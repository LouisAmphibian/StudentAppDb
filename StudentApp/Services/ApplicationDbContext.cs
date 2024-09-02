using Microsoft.EntityFrameworkCore;
using StudentApp.Models;



namespace StudentApp.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        //our table
        public DbSet<Course> Courses { get; set; }  
    }
}
