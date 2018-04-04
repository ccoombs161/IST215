namespace ModelFirstCustomerFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CustomerOrderDBContext : DbContext
    {
        public CustomerOrderDBContext()
            : base("name=CustomerOrderDBContext")
        {
        }

        public virtual DbSet<CUSTOMER> CUSTOMERs { get; set; }
        public virtual DbSet<ORDER> ORDERs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.CustomerName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.EmailDomain)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.PhoneAreaCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.City)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.State)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.ZIP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDER>()
                .Property(e => e.ProductNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDER>()
                .Property(e => e.ProductType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDER>()
                .Property(e => e.ProductName)
                .IsUnicode(false);
        }
    }
}
