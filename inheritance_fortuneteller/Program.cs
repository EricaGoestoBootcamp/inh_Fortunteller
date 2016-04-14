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
            //our game will start here
            //let's create a fortune teller
            //FortuneTeller fortuneTeller = new FortuneTeller();
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
        }

    }
}
