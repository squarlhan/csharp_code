using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_advance_event.Models
{
    //This code is for problem 1, if the result is OK, score 10;
    //The reference code is as follow:

    public delegate void NameChangeEventHandler(object sender, NameChangeArgs args);

    public class Dispatcher
    {
        private string name;

        public event NameChangeEventHandler NameChange;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
                OnNameChange(new NameChangeArgs(value));
            }
        }

        public void OnNameChange(NameChangeArgs args)
        {
            NameChange?.Invoke(this, args);
        }
    }
}
