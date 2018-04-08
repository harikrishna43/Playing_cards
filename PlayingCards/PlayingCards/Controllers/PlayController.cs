using PlayingCards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlayingCards.Controllers
{
    public class PlayController : Controller
    {
        // GET: Play
        public ActionResult Index(CardPlayers c)
        {

            List<Cardsplayers> cpList = new List<Cardsplayers>();



            Deck mydeck = new Deck();
            Random rand = new Random();

            var x = mydeck.Shuffle(mydeck.Cards);
            x = mydeck.Shuffle(x.ToArray<Card>());
            //mydeck.Cards = x;

            int indexOfNewIdx = rand.Next(x.Count());
            //int newIdxOfCard = freeIndices[indexOfNewIdx];
            Card wild_card = x[indexOfNewIdx];
            Session["wildCard"] = wild_card;
            x.RemoveAt(indexOfNewIdx);
            var latest = x;
            // CardPlayers plyr = new CardPlayers();
            int players = 0;
            int cardNumber = 5;
            //plCards lpcards = new plCards();
            while (players < c.playersCount)
            {
                plCards lpcards = new plCards();
                int _score = 0;

                cardNumber = 5;
                List<Card> player = new List<Card>();
                foreach (Card cx in x)
                {
                    if (wild_card._Suit == cx._Suit)
                    {
                        cx._Value = cx._Value * 2;
                    }
                    _score += cx._Value;
                    player.Add(cx);


                    //if()

                    cardNumber--;
                    if (cardNumber == 0)
                    {
                        break;
                    }
                }
                cardNumber = 5;
                x.RemoveRange(0, cardNumber);
                string p = "Player" + players;
                Session["PlayersCard" + players] = player;
                //c.Players_Cards=player;
                //cp.Player_card.Add(player);

                lpcards.Deal = player;
                lpcards.score = _score;
                Cardsplayers cp = new Cardsplayers();

                cp.id = players;
                cp.player = "Player :" + (players + 1);
                cp.Player_card = lpcards;
                cp.score = _score;
                cpList.Add(cp);

                players++;

            }
            Session["PlayersCard"] = cpList;


            Users user = new Users();
            var x1 = (List<Cardsplayers>)Session["PlayersCard"];
            user.user = x1;
            var card  = (Card)Session["wildCard"];
            Session["Wcard"] = card.ToString();
            return View(user);
        }
        [HttpPost]
        public ActionResult Index(Users user)
        {
            var x = (List<Cardsplayers>)Session["PlayersCard"];
            user.user = x;
            var max = x.Max(m => m.score);
            var _user = x.Where(m => m.score == max);
            Database1Entities1 dbcontext = new Database1Entities1();
            foreach (var item in x)
            {
                Score _score = new Score();
                _score.player = item.player;
                _score.score1 = item.score;
                _score.DateTime = DateTime.Now;
                dbcontext.Scores.Add(_score);
            }
            dbcontext.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}