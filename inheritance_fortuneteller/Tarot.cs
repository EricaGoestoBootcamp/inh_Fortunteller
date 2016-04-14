using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_fortuneteller
{
    //call tarot if customer phrase (build in main? contains letter d
    class Tarot : Magic
    {
        //random
        private Random random = new Random();

        //properties
        protected List<string> Phrases { get; set; } = new List<string>();

        protected List<string> Cards { get; set; } = new List<string>();

        public override string Name { get; set; } = "Tarot";


        public override void Work()
        {
            base.Work();
            //now let's call a method that will get a result for the tarot
            this.Result = GetPhrase();

        }

        protected void CreatePhrases()
        {
            Phrases.Add("*Flip* *Flip* *Flip* Hmmm,  Interesting.");
            Phrases.Add("*Flip* *Flip* *Flip*... ");
            Phrases.Add("*Shuffle* *Flip* *Flip*... ");
        }

        protected void CardPicker()
        {
            Cards.Add("The Fool");
            Cards.Add("The Magician");
            Cards.Add("the High Priestess");
            Cards.Add("The Empress");
            Cards.Add("The Emperor");
            Cards.Add("The Hierophant");
            Cards.Add("The Wheel of Fortune");
            Cards.Add("Ace of Cups");
            Cards.Add("Nine of Cups");
            Cards.Add("Five of Wands");
            Cards.Add("Knight of Wands");
            Cards.Add("Two of Pentacles");
            Cards.Add("Six of Pentacles");
            Cards.Add("Seven of Pentacles");
            Cards.Add("Ten of Pentacles");
        }

        //let's create an overloaded method now
        protected void CreatePhrases(string phrase)
        {
            Phrases.Add(phrase);
        }

        private string GetPhrase()
        {
            //local variable
            int randomNumber = random.Next(Phrases.Count);
            return Phrases.ElementAt(randomNumber);

        }



        //constructor
        //let's override some of the properties of what we inherited from magic and service here.
        public Tarot()
        {
            this.Price = 65.00M;
            this.PercentEffective = 72;
            this.BlackMagic = false;
            this.Expertise = "Journeyman";
            //I want to call my initializer for phrases.
            CreatePhrases();
        }
    }
}
