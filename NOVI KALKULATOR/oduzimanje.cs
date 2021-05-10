using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOVI_KALKULATOR
{
    class razlika
    {
        public static int oduzimanje(int n1, int n2)
        {
            int rezultat;
            rezultat = n1 - n2;
            Console.WriteLine("rezultat je {0}-{1}={2}", n1, n2, rezultat);
            return rezultat;

        }
    }
}
