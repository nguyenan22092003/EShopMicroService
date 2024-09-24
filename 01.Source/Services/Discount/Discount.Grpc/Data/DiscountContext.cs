namespace Discount.Grpc.Data;

public class DiscountContext : DbContext
{
    public DbSet<Coupon> Coupons { get; set; } = default!;

    public DiscountContext(DbContextOptions<DiscountContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Coupon>().HasData(
            new Coupon { Id = 1, ProductName = "IPhone X", Description = "Apple iPhone X with 64GB storage and 5.8-inch display.", Amount = 5 },
            new Coupon { Id = 2, ProductName = "Samsung 10", Description = "Samsung Galaxy S10 with 128GB storage and 6.1-inch display.", Amount = 10 }
        );
    }
}
