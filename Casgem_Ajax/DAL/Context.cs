using Microsoft.EntityFrameworkCore;

namespace Casgem_Ajax.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-4UM3KTM;initial catalog=CasgemAjaxDb;integrated Security=true");
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
