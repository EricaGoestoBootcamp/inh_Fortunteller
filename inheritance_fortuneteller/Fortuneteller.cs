using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_fortuneteller
{
    class FortuneTeller
    {
        //I'm just setting this up as a regular old class. 
        //Later, I might choose to make it in a game where I inherit from a Human class
        //(and have a customer also inherit from Human), but for our first round, this is great.

        //Properties
        public string Name { get; set; } = "Esmerelda"; // this Name is different from Service.Name

        public string ExperienceLevel { get; set; }

        //Methods

        public void Greet()
        {
            Console.WriteLine("Welcome to my humble shop.");
            //can ultimately implement choosing the service provider or 
            //setting services available based on the provider.
            Console.WriteLine("My name is {0}. I am a {1} level mystic in our great guild.", this.Name, this.ExperienceLevel);
            Console.WriteLine("Let me see what I have to offer you today.");

        }

        public void StartService(Service service)
        {
            Console.WriteLine("For you, my {0}! Yes, perfect. It only costs {1}.", service.Name, service.Price);
        }

        public void Farewell()
        {
            Console.WriteLine("Thank you for your patronage.");
        }

        /// <summary>
        /// Create a new fortune teller, giving it a name and experience level.
        /// </summary>
        /// <param name="name">The fortune teller's name.</param>
        /// <param name="experienceLevel">A string value (novice, journeyman, adept) for this fortune teller.</param>
        /// 

        //Constructors
        public FortuneTeller(string name, string experienceLevel)
        {
            this.Name = name;
            this.ExperienceLevel = experienceLevel;

        }

        public FortuneTeller()
        {
        }
    }


}
