using System.ComponentModel.DataAnnotations;

namespace InventorySystemAPI.Models{

  public class Game{ 

    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Platform { get; set; }
    public string Category { get; set; }
    public int Rating { get; set; }
    public int AgeRestriction { get; set; }
    public string ReleaseDate { get; set; }
    
  }

}