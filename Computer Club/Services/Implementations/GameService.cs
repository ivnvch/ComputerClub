using Computer_Club.Model;
using Computer_Club.Model.DataBaseModels;
using Computer_Club.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Computer_Club.Services.Implementations
{
    public class GameService : IGame
    {
        private readonly ApplicationDataBaseContext applicationDataBaseContext;

        public GameService(ApplicationDataBaseContext applicationContext)
        {
            this.applicationDataBaseContext = applicationContext;
        }

        public void Create(Game game)
        {
           applicationDataBaseContext.Games.Add(game);
            applicationDataBaseContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var game = applicationDataBaseContext.Games.FirstOrDefault(x => x.Id == id);
            if (game != null)
            {
                applicationDataBaseContext.Games.Remove(game);
                applicationDataBaseContext.SaveChanges();   
            }
            throw new Exception("This game is not on the computer!");
        }

        public Game GetGameById(int id)
        {
            return applicationDataBaseContext.Games.FirstOrDefault(x=>x.Id == id);
        }

        public IEnumerable<Game> GetGames() => applicationDataBaseContext.Games.AsNoTracking().ToList();

        public void Update(int id, Game game)
        {
            var updateGame = applicationDataBaseContext.Games.FirstOrDefault(x => x.Id == id);
            if (updateGame == null)
            {
                throw new Exception("Game not found");
            }
            updateGame = game;
            applicationDataBaseContext.Games.Update(updateGame);
            applicationDataBaseContext.SaveChanges();
        }
    }
}
