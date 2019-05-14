using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_advance_event.Models
{
    //This code is for problem 1, if the result is OK, score 10;
    //The reference code is as follow:

    class Handler
    {
        public void OnDispatcherNameChange(object sender, NameChangeArgs args)
        {
            Console.WriteLine($"Dispatcher's name changed to {args.Name}.");
        }
    }
}
