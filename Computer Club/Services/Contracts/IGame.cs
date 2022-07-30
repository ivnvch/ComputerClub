using Computer_Club.Model.DataBaseModels;

namespace Computer_Club.Services.Contracts
{
    public interface IGame
    {
        IEnumerable<Game> GetGames();
        Game GetGameById(int id);
        void Create(Game game);
        void Update(int id, Game game);
        void Delete(int id);
    }
}
