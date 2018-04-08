using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlayingCards
{
    public class CardPlayers
    {
        public int playersCount { get; set; }
        public Card wild_card { get; set; }
        public int winner { get; set; }
        public List<Card>Players_Cards { get; set; }
        public List<int> score { get; set; }
    }

    public class Cardsplayers
    {
        public int id { get; set; }
        public string player { get; set; }
        public plCards Player_card{ get; set; }
        public int score { get; set; }
    }

    public class plCards{
        public List<Card>Deal{ get; set; }
        public int score { get; set; }
    }

    public class Users {
        public List<Cardsplayers> user { get; set; }
    }

}