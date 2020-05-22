namespace SalesManager
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderStatu> OrderStatus { get; set; }
        public virtual DbSet<PayStatu> PayStatus { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Customer1)
                .HasForeignKey(e => e.Customer);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.Emplotyee);

            modelBuilder.Entity<Order>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.Contracts)
                .WithOptional(e => e.Order1)
                .HasForeignKey(e => e.Order);

            modelBuilder.Entity<OrderStatu>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.OrderStatu)
                .HasForeignKey(e => e.Status);

            modelBuilder.Entity<PayStatu>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.PayStatu)
                .HasForeignKey(e => e.CostStatus);

            modelBuilder.Entity<Position>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.Position1)
                .HasForeignKey(e => e.Position);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Service1)
                .HasForeignKey(e => e.Service);
        }
    }
}
