using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PlayingCards
{
    public enum Suits
    {
        Hearts,
        Diamonds,
        Spades,
        Clubs
    }
    public class Card
    {
        protected Suits suit;
        protected string cardvalue;
        protected int _value;

        public Suits _Suit
        {
            set
            {
                value = this.suit;
            }
            get
            {
                return this.suit;
            }
        }
        public string _cardvalue
        {
            set
            {
                value = this.cardvalue;
            }
            get
            {
                return this.cardvalue;
            }
        }
        public int _Value
        {
            set
            {
                value = this._value;
            }
            get
            {
                return this._value;
            }
        }

        public Card()
        {


        }
        public Card(Suits suit2, string cardvalue2)
        {
            suit = suit2;
            cardvalue = cardvalue2;
            switch (cardvalue2)
            {
                case "A":
                    _value = 11;
                    break;
                case "K":
                    _value = 4;
                    break;
                case "Q":
                    _value = 3;
                    break;
                case "J":
                    _value = 2;
                    break;

                case "10":
                    _value = 10;
                    break;
                default:
                    _value = 0;
                    break;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} of {1}\n", cardvalue, suit);
        }
    }
}