using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
  public DataContext(DbContextOptions<DataContext> options) : base(options) { }
  
  public DbSet<Category> Categories { get; set; }
  public DbSet<Product> Products { get; set; }
  public DbSet<Discount> Discounts { get; set; }
  public DbSet<Customer> Customer { get; set; }

  public void AddCustomer(Customer customer)
  {
    this.Add(customer);
    this.SaveChanges();
  }

}