using Microsoft.EntityFrameworkCore;

namespace InventorySystemAPI.Models{

  public class InventorySystemContext : DbContext{

    public InventorySystemContext(DbContextOptions<InventorySystemContext> options):base(options){}
    public DbSet<InventorySystemAPI.Models.Game> Game { get; set; }

  }

}