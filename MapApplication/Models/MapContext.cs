namespace MapApplication.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MapContext : DbContext
    {
        
        public MapContext() : base("name=MapContext")
        {
        }
        public virtual DbSet<AtractionDb> AtractionDb { get; set; }
        public virtual DbSet<City> City { get; set; }
    }
    
}