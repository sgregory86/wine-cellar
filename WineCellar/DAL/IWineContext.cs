using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using WineCellar.Models;

namespace WineCellar.DAL
{
    public interface IWineContext : IDisposable
    {
        IDbSet<Wine> Wines { get; set; }
        int SaveChanges();
        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
    }
}