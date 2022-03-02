using System.Runtime.InteropServices;
using System;
using Microsoft.EntityFrameworkCore;

namespace Authentification
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Livre> Livres { get; set; }
    }


}
