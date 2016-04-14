using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_fortuneteller
{
    class DaySpa : Service
    {
        //basic day spa: facial, chemical peel, eyebrow threading, paraffin wrap
        //only chemical peel is currently implemented

        //let's make sure all spa services have a name!
        public override string Name { get; set; } = "facial";

        //How about a  work -- "make it go now" method?
        public virtual void Work()
        {
            Console.WriteLine("we are now performing a {0}", this.Name);
        }
        //What about a Show method for sharing the results
        public virtual void Show()
        {
            Console.WriteLine("The {0} is complete.", this.Name); 
            Console.WriteLine("Don't you feel more beautiful?", this.Name); 
            //Console.WriteLine(this.Result); // not used for now
        }

        public virtual void Farewell()
        {
            Console.WriteLine("Thank you for your patronage.\nHave you thought about doing something about that...thing?");
            Console.WriteLine("You know, the thing on your face? We could help with that.");
        }

            //default constructor
            public void dayspa()
        {
            this.Price = 87.00M; // pricing not currently implemented
            
        }

    }
    
}
