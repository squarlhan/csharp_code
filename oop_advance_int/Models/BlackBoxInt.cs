using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_advance_int.Models
{
    //This code is for problem 2, if the result is OK, score 10;
    //The reference code is as follow:

    class BlackBoxInt
    {
        private static int DefaultValue = 0;

        private int innerValue;

        private BlackBoxInt(int innerValue)
        {
            this.innerValue = innerValue;
        }

        private BlackBoxInt()
        {
            this.innerValue = DefaultValue;
        }

        private void Add(int addend)
        {
            this.innerValue += addend;
        }

        private void Subtract(int subtrahend)
        {
            this.innerValue -= subtrahend;
        }

        private void Multiply(int multiplier)
        {
            this.innerValue *= multiplier;
        }

        private void Divide(int divider)
        {
            this.innerValue /= divider;
        }

        private void LeftShift(int shifter)
        {
            this.innerValue <<= shifter;
        }

        private void RightShift(int shifter)
        {
            this.innerValue >>= shifter;
        }
    }
}
