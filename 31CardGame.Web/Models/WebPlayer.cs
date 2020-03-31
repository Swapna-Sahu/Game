using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _31CardGame.Shared.Models;

namespace _31CardGame.Web.Models
{
    public class WebPlayer : Player
    {
        public WebPlayer(string name) : base(name)
        {

        }

        public override void Turn(Game game)
        {
            //Do nothing
        }
    }
}