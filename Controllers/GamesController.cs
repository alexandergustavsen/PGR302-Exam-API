using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using InventorySystemAPI.Models;

namespace InventorySystemAPI.Controllers{

  [ApiController]
  [Route("[controller]")]

  public class GamesController : Controller {

    private readonly InventorySystemContext _context;

    public GamesController(InventorySystemContext context){
      _context = context;
    }

    [HttpGet]
    public async Task<IEnumerable<Game>> Get(){

      /*UNCOMMENT THIS TO REGISTER DATA AT FIRST LAUNCH OF THE WEBAPI
      _context.Game.AddRange( 
        new Game { 
          Name = "Fortnite",
          Platform = "PS4, XBOX, PC",
          Category = "TPS",
          Rating = 9,
          AgeRestriction = 12,
          ReleaseDate = "21. July, 2017"
        },
        new Game { 
          Name = "Minecraft",
          Platform = "PS4, XBOX, PC",
          Category = "Creative",
          Rating = 8,
          AgeRestriction = 7,
          ReleaseDate = "17. May, 2009"
        },
        new Game { 
          Name = "World of Warcraft",
          Platform = "PC",
          Category = "MMORPG",
          Rating = 8,
          AgeRestriction = 12,
          ReleaseDate = "23. November, 2004"
        },
        new Game { 
          Name = "Overwatch",
          Platform = "PS4, XBOX, PC",
          Category = "FPS",
          Rating = 7,
          AgeRestriction = 12,
          ReleaseDate = "24. May, 2016"
        },
        new Game { 
          Name = "Death Stranding",
          Platform = "PS4",
          Category = "Space",
          Rating = 7,
          AgeRestriction = 18,
          ReleaseDate = "8. November, 2019"
        },
        new Game { 
          Name = "Rocket League",
          Platform = "PS4, XBOX, PC",
          Category = "Race",
          Rating = 7,
          AgeRestriction = 8,
          ReleaseDate = "7. July, 2015"
        },
        new Game { 
          Name = "Counter Strike: Global Offensive",
          Platform = "PC",
          Category = "FPS",
          Rating = 8,
          AgeRestriction = 18,
          ReleaseDate = "21. August, 2012"
        },
        new Game { 
          Name = "Forza Horizon 4",
          Platform = "XBOX, PC",
          Category = "Race",
          Rating = 6,
          AgeRestriction = 8,
          ReleaseDate = "28. September, 2018"
        },
        new Game { 
          Name = "Destiny 2",
          Platform = "PS4, XBOX, PC",
          Category = "TPS",
          Rating = 6,
          AgeRestriction = 12,
          ReleaseDate = "6. September, 2017"
        },
        new Game { 
          Name = "Doom",
          Platform = "PC",
          Category = "FPS",
          Rating = 7,
          AgeRestriction = 12,
          ReleaseDate = "13. May, 2016"
        }
      );
      await _context.SaveChangesAsync();
      */

      List<Game> gameList = await _context.Game.ToListAsync();
      return gameList;
    }

    [HttpPost]
    public async Task<Game> Post(Game newGame){
      _context.Game.Add(newGame);
      await _context.SaveChangesAsync();
      return newGame;
    }

    [HttpPut]
    public async Task<Game> Put(Game updateGame){
      _context.Update(updateGame);
      await _context.SaveChangesAsync();
      return updateGame;
    }

    [HttpDelete("{id}")]
    public async Task<Game> Delete(int id) {
      Game deleteGame = await _context.Game.FirstAsync(
        game => game.Id == id
      );
      _context.Game.Remove(deleteGame);
      await _context.SaveChangesAsync();
      return deleteGame;
    }

  }
}