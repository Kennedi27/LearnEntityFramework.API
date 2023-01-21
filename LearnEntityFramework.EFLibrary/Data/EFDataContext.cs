using LearnEntityFramework.EFLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace LearnEntityFramework.EFLibrary.Data
{
    public class EFDataContext : DbContext
    {
        public EFDataContext(DbContextOptions<EFDataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            base.OnModelCreating(modelBuilder);
        }


    }
}
