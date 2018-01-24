using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MapApplication.Models
{
    public class MapsDBContext1 : DbContext
    {
        public MapsDBContext1() : base("name=MapsDBContext1")
        {
        }

        public virtual DbSet<MapsDB> MapsDB { get; set; }
        public virtual DbSet<City> City { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MapsDB>()
                .Property(e => e.AtractionName)
                .IsUnicode(false);

            modelBuilder.Entity<MapsDB>()
                .Property(e => e.City)
                .IsUnicode(false);
        }
    }
}