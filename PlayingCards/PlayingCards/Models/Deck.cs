using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlayingCards
{
    public class Deck
    {
        Card[] cards = new Card[52];
        string[] numbers = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        public Deck()
        {
            int i = 0;
            foreach (string s in numbers)
            {
                cards[i] = new Card(Suits.Clubs, s);
                i++;

            }
            foreach (string s in numbers)
            {
                cards[i] = new Card(Suits.Spades, s);
                i++;

            }
            foreach (string s in numbers)
            {
                cards[i] = new Card(Suits.Hearts, s);
                i++;

            }
            foreach (string s in numbers)
            {
                cards[i] = new Card(Suits.Diamonds, s);
                i++;

            }
        }

        public Card[] Cards
        {
            get
            {
                return cards;


            }
            set { }
        }

        public List<Card> Shuffle(Card[] Cards)
        {
            Card[] currentDeck = Cards;
            this.Cards = new Card[currentDeck.Length];
            List<int> freeIndices = new List<int>(currentDeck.Length);
            Random rand = new Random();

            for (int idx = 0; idx < currentDeck.Length; idx++)
                freeIndices.Add(idx);
            Deck d = new Deck();
            d.Cards = null;
            foreach (Card card in currentDeck)
            {
                int indexOfNewIdx = rand.Next(freeIndices.Count);
                int newIdxOfCard = freeIndices[indexOfNewIdx];

                d.Cards[newIdxOfCard] = card;
                freeIndices.Remove(newIdxOfCard);

            }
            return d.Cards.ToList<Card>();
        }
    }
}