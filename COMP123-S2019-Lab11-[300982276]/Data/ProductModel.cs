namespace COMP123_S2019_Assignment5__300982276_.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProductModel : DbContext
    {
        public ProductModel()
            : base("name=ProductModelConnection")
        {
        }

        public virtual DbSet<products> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<products>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);
        }
    }
}
