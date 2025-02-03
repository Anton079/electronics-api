using electronics_api.Electronics.Models;
using Microsoft.EntityFrameworkCore;


namespace electronics_api.Data.Migrations
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }

        public virtual DbSet<Electronic> Electronics { get; set; }
    }
}
