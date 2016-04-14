using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_fortuneteller
{
    class Garden : Service
    { // NOT FINISHED
        //basic day spa: chemical peel, eyebrow threading, paraffin wrap

        //let's make sure all spa services have a name!
        public override string Name { get; set; }

        
        //How about a  work -- "make it go now" method?
        public virtual void Work()
        {
            Console.WriteLine("we are now performing a {0}", this.Name);

        }
        //What about a Show method for sharing the results -- showing the magical object to the user?
        public virtual void Show()
        {
            Console.WriteLine("The {0} is complete.", this.Name);
            Console.WriteLine("Don't you feel younger and more beautiful? DON'T YOU?!", this.Name);
            Console.WriteLine(this.Result); // this. result will come from the specific service we set up
        }
    }
}
