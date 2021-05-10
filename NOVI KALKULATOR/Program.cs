using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOVI_KALKULATOR
{
    class Program

    {
           static void Main(string[] args)
          
        {
            
            
            int n1, n2, rezultat;
            Console.WriteLine("Izaberite zeljenu operaciju  + - * /");
            string operacija = Console.ReadLine();
            Console.WriteLine("unesite prvu operandu n1  ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("unesite drugu operandu n2  ");
            n2 = Convert.ToInt32(Console.ReadLine());

            switch (operacija)
            {
                case "+":
                    rezultat = sabirak.sabiranje(n1, n2);
                    break;
                case "-":
                    rezultat = sabirak.oduzimanje(n1, n2);
                    break;
                case "*":
                    rezultat = sabirak.mnozenje (n1, n2);
                    break;
                case "/":
                    rezultat = sabirak.deljenje(n1, n2);
                    break;
                default:
                    Console.WriteLine("Pogresna operacija");
                    Environment.Exit(1);
                    break;

            }
            
            Console.ReadKey();


        }
       
          
        
    }
       
}
