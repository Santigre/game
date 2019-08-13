using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there, what is your name?");
            string HeroName = Console.ReadLine();
            Console.WriteLine("So your name is " + HeroName + "? Nice to meat you!");
            Console.WriteLine("Well lets get started. Im going to need you to go out in the woods and kill some spiders for me.");
            Console.WriteLine("Do you think you can handle that? yes/no");
            string HeroReady = Console.ReadLine();
            int StartingAtk = 1;
            int Staringhp = 20;


            if (HeroReady == "yes")
            {
                Hero hero = new Hero(HeroName, StartingAtk, Staringhp);
                Tutorial tutorial = new Tutorial();
                Console.WriteLine("Great see you later!");
                Console.ReadLine();
                
            }

            if (HeroReady == "no")
            {
                Console.WriteLine("goodbye then!");
            }


            Console.WriteLine(HeroName + StartingAtk + Staringhp);
            Console.ReadLine();

        }
    }
}
