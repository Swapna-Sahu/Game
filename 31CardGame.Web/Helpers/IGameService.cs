using _31CardGame.Shared.Models;

namespace _31CardGame.Web.Helpers
{
    public interface IGameService
    {
        void DeleteGame(int id);
        bool GameExist(int id);
        Game LoadGame(int id);
        void SaveGame(Game game);
    }
}
