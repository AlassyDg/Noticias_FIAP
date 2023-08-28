using Microsoft.EntityFrameworkCore;
using Webapiaspnet.Models;

namespace Webapiaspnet.Data
{
    public class WebapiContext : DbContext 
    {
        public WebapiContext(DbContextOptions<WebapiContext> opts)
            : base(opts)
        {
                
        }
        public DbSet<Noticia> Noticia { get; set; }
    }
}