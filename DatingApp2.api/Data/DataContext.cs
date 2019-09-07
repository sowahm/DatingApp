using DatingApp2.api.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp2.api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
       

        public DbSet<Value> Values {get; set; }   
        
    }
}