using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.model
{
    public class EmlakContext : DbContext
    {
        public DbSet<Ev> Evler  { get; set; }
        public DbSet<Kullanici> kullanicis { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EvDbFinal;Integrated Security=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ev>().ToTable("tblEvler");
            //modelBuilder.Entity<Ev>().Property(e => e.Semt).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Kullanici>().ToTable("tblUsers");
            modelBuilder.Entity<Kullanici>().Property(a => a.Ad).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Kullanici>().Property(s => s.Sifre).HasColumnType("varchar").HasMaxLength(30).IsRequired();
        }
    }
}
