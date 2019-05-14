using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_advance_event.Models
{
    //This code is for problem 1, if the result is OK, score 10;
    //The reference code is as follow:

    public class NameChangeArgs : EventArgs
    {
        public NameChangeArgs(string name)
        {
            this.Name = name;
        }

        public string Name { get; protected set; }
    }
}
