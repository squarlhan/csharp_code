﻿using oop_advance_event.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_advance_event
{
    class Program
    {
        //This code is for problem 1, if the result is OK, score 10;
        //The reference code is as follow:

        static void Main(string[] args)
        {
            Dispatcher dispatcher = new Dispatcher();
            Handler handler = new Handler();

            dispatcher.NameChange += handler.OnDispatcherNameChange;

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "End")
            {
                dispatcher.Name = line;
            }
        }
    }
}
