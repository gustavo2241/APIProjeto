using Microsoft.EntityFrameworkCore;

namespace api.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){

        }

        public DbSet<Estoque> TB_PRODUTOS {get; set;}
    }
}