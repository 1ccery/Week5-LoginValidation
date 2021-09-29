using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //programm küsib kasutajal sisestada pin koodi arvuga 1234
            // program võrdleb siestatud pn koodi arvuga 1234
            // kui on sisestatud 1234
            // prgramm kuvab konsoolis "tere tulemast
            //kui sis pin on vale programm kuvab
            //vale pin try again
            //katsete arv piiramatu"
            //boolean ---> true/false
            //bool loopActive = true;

            int i = 0;

            while (i < 3)
            {

                Console.WriteLine("Sisesta PIN");
                int UserPin = Convert.ToInt32(Console.ReadLine());

                i = i + 1;
                if (UserPin == 1234)
                {
                    Console.WriteLine("Tere tulemast");
                    

                    i = 3;
                }

                else
                {
                    Console.WriteLine("Proovi uuesti vale");
                    Console.WriteLine($"Vale PIN {3 - i} katset pn jäänud");


                }
            }


            Console.WriteLine("kenapäeva nokud");


        }
    }
}
