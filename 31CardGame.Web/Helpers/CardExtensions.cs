using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _31CardGame.Shared.Models;

namespace _31CardGame.Web.Helpers
{
    public static class CardExtensions
    {
        public static string FileName(this Card c)
        {
            return $"{c.Rank}_of_{c.Suit.ToString().ToLower()}.png";
        }
    }
}