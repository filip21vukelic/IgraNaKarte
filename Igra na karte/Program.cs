using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Igra_na_karte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int karte = 0;
            int CardCounter = 0;

            Console.WriteLine("Unesi kartu: ");
            while (CardCounter < 31)
            {
                karte = Convert.ToInt32(Console.ReadLine());

                if(karte <= 13 && karte >= 1)
                {
                    CardCounter += karte;
                }
                else {
                    Console.WriteLine(" Unesi ispravnu kartu od 1 do 13");
                        }
                
            }
            if(CardCounter == 31)
            {
                Console.WriteLine("Pobjeda");
            }
            else if(CardCounter > 31)
            {
                Console.WriteLine("Gubitak");
            }
            Console.ReadKey();
        }
    }
}
