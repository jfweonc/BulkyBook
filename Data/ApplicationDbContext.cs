using Microsoft.EntityFrameworkCore;
using MVCBulkyBook.Models;

namespace MVCBulkyBook.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

    }
}
