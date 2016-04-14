using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_fortuneteller
{

    class Program
    {
        static void Main(string[] args)
        {
            //MAIN MENU
            Console.WriteLine("Please pick a service:");
            Console.WriteLine("1. Fortune Teller");
            Console.WriteLine("2. Day Spa");
            Console.WriteLine("Enter 1 or 2\n");
            Console.WriteLine(" * * * * * *  * * * * ");
            int menuItem = int.Parse(Console.ReadLine());

            //Main menu switch selector - spa is a bit lame but it works
            switch (menuItem)
            {
                case 1:
                    Console.WriteLine("You have chosen our fortune telling service.");
                    FortuneTeller fortuneTeller = new FortuneTeller("Anjanie", "journeyman");
                    CrystalBall crystalBall = new CrystalBall();
                    fortuneTeller.Greet(); //say hi
                    fortuneTeller.StartService((Service)crystalBall); //talk about the service that's being performed
                    Console.WriteLine("Enter an object that has significance to you.");
                    string treasuredObject = Console.ReadLine();
                    crystalBall.Work(); //run it (do the service)
                    crystalBall.Show(treasuredObject); //display it (state results of the service)
                    crystalBall.StateEffectiveness(); //state effectiveness of service.
                    fortuneTeller.Farewell(); //say goodbye.
                    break;
                case 2:
                    Console.WriteLine("You have chosen our spa.");
                    Console.WriteLine("We provide the best spa services in the tri state area.");
                    DaySpa dayspa = new DaySpa();
                    //ChemicalPeel chemicalpeel = new ChemicalPeel(); 
                    dayspa.Work(); // do the service
                    dayspa.Show(); // show the result
                    dayspa.Farewell(); // say good bye
                    
                    //enter new options here - case 3: 

                    break;
                default:
                    Console.WriteLine("I did not understand your request. Ending.");
                    break;
            }


        }

    }
}
