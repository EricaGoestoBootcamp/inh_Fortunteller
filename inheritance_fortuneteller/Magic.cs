using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_fortuneteller
{
    class Magic : Service
    {
        //what is at the base of a magical item?
        //in our base class, let's say that they all have good or bad magic. In this case, let's just say it's black magic, or just magic.
        //now, we have to decide what kind of datatype we want to use to store it. 
        //Since there are only 2 values, it would be very efficient to use a bool
        //property
        public virtual bool BlackMagic { get; set; }

        //how about another property that gives us the effectiveness of this magical item?
        public virtual int PercentEffective { get; set; }

        //let's make sure all of them have a name!
        public override string Name { get; set; }

        //let's throw in the level of expertise the fortune teller needs to use this item
        protected virtual string Expertise { get; set; }

        //How about a  work -- "make it go now" method?
        public virtual void Work()
        {
            Console.WriteLine("Let me pull out my {0}", this.Name);
        }
        //What about a Show method for sharing the results -- showing the magical object to the user?
        public virtual void Show()
        {
            Console.WriteLine("The {0} has pulled back the curtain of fate.", this.Name);
            Console.WriteLine(this.Result);
        }
        public virtual void Show(string treasure)
        {
            Console.WriteLine("The {0} has pulled back the curtain of fate.", this.Name);
            Console.WriteLine("The " + treasure + this.Result);
        }
        public virtual void StateEffectiveness()
        {
            Console.WriteLine("In case you're wondering, {0} is {2} percent effective.", this.Name, this.Result, this.PercentEffective);
        }
    }

}
