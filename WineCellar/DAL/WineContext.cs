using WineCellar.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WineCellar.DAL
{
    public class WineContext : DbContext, IWineContext
    {
        public IDbSet<Wine> Wines { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}