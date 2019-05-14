﻿using oop_advance_card.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_advance_card.Models
{
    //This code is for problem 3,4,5, if the result is OK, score 30;
    //The reference code is as follow:
    public class Card : IComparable<Card>
    {
        public Card(string cardRank, string cardSuit)
        {
            this.CardRank = (CardRank)Enum.Parse(typeof(CardRank), cardRank);
            this.CardSuit = (CardSuit)Enum.Parse(typeof(CardSuit), cardSuit);
        }

        public CardRank CardRank { get; private set; }
        public CardSuit CardSuit { get; private set; }

        public int CardPower
        {
            get
            {
                return (int)this.CardRank + (int)this.CardSuit;
            }
        }

        public int CompareTo(Card other)
        {
            int result = other.CardPower.CompareTo(this.CardPower);

            return result;
        }

        public override string ToString()
        {
            return $"Card name: {Enum.GetName(typeof(CardRank), this.CardRank)} of {Enum.GetName(typeof(CardSuit), this.CardSuit)}; Card power: {this.CardPower}";
        }
    }
}
