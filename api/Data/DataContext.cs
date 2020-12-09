using Microsoft.EntityFrameworkCore;
using Models;

namespace api.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {           
        }
        
        public DbSet<Values> Values { get; set; }
        
    }
}