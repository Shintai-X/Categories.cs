using Microsoft.EntityFrameworkCore;
using System.Drawing;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDBcontext:DbContext
    {
        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext>options):base(options)
        {

        }

        public DbSet<Categorie>categories { get; set; }


   }
}
