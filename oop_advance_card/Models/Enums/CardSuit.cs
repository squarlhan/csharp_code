using oop_advance_card.Models.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_advance_card.Models.Enums
{
    //This code is for problem 1, if the result is OK, score 10;
    //The reference code is as follow:
    [TypeAttribute("Enumeration", "Suit", "Provides suit constants for a Card class.")]
    public enum CardSuit
    {
        Clubs = 0,
        Diamonds = 13,
        Hearts = 26,
        Spades = 39
    }
}
