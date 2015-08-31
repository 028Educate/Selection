using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    class Program
    {
        const int maxSharkTeeth = 240;
        static int sharkTeeth;

        static void Main(string[] args)
        {
            IfStatement();
            IfElseStatement();
            IfElseIfStatement();
            SwitchStatement();
        }

        private static void IfStatement()
        {
            sharkTeeth = 210;

            if(sharkTeeth < maxSharkTeeth)
            {
                Console.WriteLine("C Shark does not have all his teeth. He has lost " 
                    + (maxSharkTeeth - sharkTeeth) + " teeth");
            }
        }

        private static void IfElseStatement()
        {
            sharkTeeth = 240;

            if (sharkTeeth < maxSharkTeeth)
            {
                Console.WriteLine("C Shark does not have all his teeth. He has lost "
                    + (maxSharkTeeth - sharkTeeth) + " teeth");
            }
            else
            {
                Console.WriteLine("C Shark has all his razor sharp teeth");
            }
        }
        private static void IfElseIfStatement()
        {
            sharkTeeth = 241;

            if (sharkTeeth < maxSharkTeeth)
            {
                Console.WriteLine("C Shark does not have all his teeth. He has lost "
                  + (maxSharkTeeth - sharkTeeth) + " teeth");              
            }
            else if (sharkTeeth > maxSharkTeeth)
            {
                Console.WriteLine("C Shark has too many teeth ... Get biting some boats!");
            }
            else
            {
                Console.WriteLine("C Shark has exactly " + maxSharkTeeth + " teeth");
            }     
        }

        private static void SwitchStatement()
        {
            string sharkMood = "Happy";

            switch(sharkMood)
            {
                case "Angry": Console.WriteLine("C Shark is angry ... Everyone hide from him!");
                    break;
                case "Sleepy": Console.WriteLine("C Shark is tired of hunting .... Sleep time!");
                    break;
                case "Hungry": Console.WriteLine("C Shark is hungry ... Beware!");
                    break;
                default: Console.WriteLine("C Shark is perfectly content!");
                    break;
            }
        }
    }
}
