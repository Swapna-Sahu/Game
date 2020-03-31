using _31CardGame.Shared.Models;
using _31CardGame.Web.Models;

namespace _31CardGame.Web.Models
{
    public class GameViewModel
    {
        public Game CurrentGame { get; set; }

        public WebPlayer CurrentPlayer { get; set; }
    }
}