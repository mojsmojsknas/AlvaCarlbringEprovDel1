using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlvaCarlbringEprovDel1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Jag testade bara lite för jag råkade förvirra mig själv
             Hero test = new Hero();
            string testnamn = Console.ReadLine();
            test.name = testnamn;
            Console.WriteLine(test.name);
            Console.WriteLine(test.Hp);
            test.Hp = 75;
            Console.WriteLine(test.Hp);
            Console.ReadLine();
            */

            bool ok = false;

          
            Console.WriteLine("Hej och välkommen till Superhero Academy! Vilken sorts hjälte vill du köra som?");
            Console.WriteLine("1 = Eld");
            Console.WriteLine("2 = Snö");
            Console.WriteLine("3 = Vatten");
            string ans = Console.ReadLine();

            if (ans == "1")
            {
                Fire player = new Fire();
            }
            if (ans == "2")
            {
                Snow player = new Snow();
            }
            if (ans == "3")
            {
                Water player = new Water();
            }
            else 
            {
                Console.WriteLine("Då du inte valde något av alternativen så blir du skräp");
                Trash player = new Trash();
            }

            

            
        }
        
        //Wow jag fick helt hjärnsläpp 
        /*
     public string Name()
        {
           bool ok = false;
            while (ok == false)
            {
                Console.WriteLine("Vad heter din hjälte?");

                string chaName = Console.ReadLine();

                Console.WriteLine("Är du nöjd med att heta " + chaName + "?");
                Console.WriteLine("1 = Ja");
                Console.WriteLine("2 = Nej");
                string ans = Console.ReadLine();
                if (ans == "1")
                {
                    
                    ok = true;
                    return chaName;
                }
                if (ans != "1")
                {
                    Console.WriteLine("Synd att du inte gillar det");
                }

            }
        }
        */
    }
}
