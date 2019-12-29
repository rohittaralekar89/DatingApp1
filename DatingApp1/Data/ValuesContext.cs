using DatingApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp1.Data
{
    public class ValuesContext: DbContext
    {
        public ValuesContext(DbContextOptions<ValuesContext> options): base(options) {}
        public DbSet<Value> Values { get; set; } 
    }
}
