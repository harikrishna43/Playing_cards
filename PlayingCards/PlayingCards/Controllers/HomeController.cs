using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlayingCards.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //CardPlayers count = new CardPlayers();
            //count.playersCount= 3;
            //Deck mydeck = new Deck();
            //Random rand = new Random();

            //var x = mydeck.Shuffle(mydeck.Cards);
            //x = mydeck.Shuffle(x.ToArray<Card>());
            ////mydeck.Cards = x;

            //int indexOfNewIdx = rand.Next(x.Count());
            ////int newIdxOfCard = freeIndices[indexOfNewIdx];
            //var wild_card = x[indexOfNewIdx];
            //x.RemoveAt(indexOfNewIdx);
            //var latest = x;
            //int players = 3;
            //int cardNumber = 5;

            //while (players > 0)
            //{
            //    cardNumber = 5;
            //    List<Card> player = new List<Card>();
            //    foreach (var c in x)
            //    {
            //        player.Add(c);
                    
            //        cardNumber--;
            //        if(cardNumber==0)
            //        { break; }
            //    }
            //    cardNumber = 5;
            //    x.RemoveRange(0, cardNumber);
            //    string p = "Player" + players;
            //    ViewData["player"+ players] = player;
            //    players--;

            //}
            

            return View();
        }

        [HttpPost]
        public ActionResult Index(CardPlayers c)
        {
           // List<Cardsplayers> cpList = new List<Cardsplayers>();

            

           // Deck mydeck = new Deck();
           // Random rand = new Random();

           // var x = mydeck.Shuffle(mydeck.Cards);
           // x = mydeck.Shuffle(x.ToArray<Card>());
           // //mydeck.Cards = x;

           // int indexOfNewIdx = rand.Next(x.Count());
           // //int newIdxOfCard = freeIndices[indexOfNewIdx];
           // Card wild_card = x[indexOfNewIdx];
           // Session["wildCard"] = wild_card;
           // x.RemoveAt(indexOfNewIdx);
           // var latest = x;
           //// CardPlayers plyr = new CardPlayers();
           // int players = 0;
           // int cardNumber = 5;
           // //plCards lpcards = new plCards();
           // while (players < c.playersCount)
           // {
           //     plCards lpcards = new plCards();
           //     int  _score = 0;
                
           //     cardNumber = 5;
           //     List<Card> player = new List<Card>();
           //     foreach (Card cx in x)
           //     {
           //         if (wild_card._Suit == cx._Suit)
           //         {
           //             cx._Value = cx._Value * 2;
           //         }
           //         _score += cx._Value;
           //         player.Add(cx);
                    
                    
           //         //if()

           //         cardNumber--;
           //         if (cardNumber == 0)
           //         {
           //             break;
           //         }
           //     }
           //     cardNumber = 5;
           //     x.RemoveRange(0, cardNumber);
           //     string p = "Player" + players;
           //     Session["PlayersCard"+players] = player;
           //     //c.Players_Cards=player;
           //     //cp.Player_card.Add(player);
                
           //     lpcards.Deal=player;
           //     lpcards.score = _score;
           //     Cardsplayers cp = new Cardsplayers();

           //     cp.id = players;
           //     cp.player = "Player :" + (players + 1);
           //     cp.Player_card = lpcards;
           //     cp.score = _score;
           //     cpList.Add(cp);

           //     players++;

           // }
           // Session["PlayersCard"] = cpList;
            return RedirectToAction("index","Play",c);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}