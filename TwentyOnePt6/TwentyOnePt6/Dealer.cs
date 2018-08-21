using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace TwentyOnePt6
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }


        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            //========APPEND TEXT========// 
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Rembrandt.Evora\Desktop\2018 Tech Academy Bootcamp\C# & .NET Framework Course Documents\logtest.txt", true))
            {
                //StreamWriter takes path of log, and "true" argument is so that it 
                //it appends, if "false", creates new file
                file.WriteLine(card); //To write 'string card' line 21, to the file. 
            } //Once program hits this bracket, it clears the memory via the 'using' statement, rather than accumulate in memory storage
            Deck.Cards.RemoveAt(0);


        }
    }
}
