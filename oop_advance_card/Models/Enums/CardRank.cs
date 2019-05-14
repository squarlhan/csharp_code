using oop_advance_card.Models.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_advance_card.Models.Enums
{
    //This code is for problem 2, if the result is OK, score 10;
    //The reference code is as follow:
    [TypeAttribute("Enumeration", "Rank", "Provides rank constants for a Card class.")]
    public enum CardRank
    {
        Ace = 14,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }
}
