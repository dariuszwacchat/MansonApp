using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace ConsoleApp9
{
    class Program
    {

        public delegate void Del(int a, int b);
        public static void metodaDoDelegata(int a, int b)
        {
            Console.WriteLine(a - b);
            Console.WriteLine(a - b);
            SSSSSSSSSSSSSSSSSSSSSSSSSSSSsss
        }
        public static void Dodawanie(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public class KlasaDoDelegata
        {
            public void Mnozenie(int a, int b)
            {
                Console.WriteLine(a * b);
            }
            public void Dzielenie(int a, int b) =>
                Console.WriteLine(a / b);
        }

        // -----------------------------------------

        delegate void DelegatNumerDwa();
        public class KlasaDruga
        {
            public void metodaA() => Console.WriteLine("metoda dynamiczna");
            public static void metodaB() => Console.WriteLine("metoda statyczna");
        }

        static void Main(string[] args)
        {
            Del d = metodaDoDelegata;
            Del dodawanie = Dodawanie;
            d(10, 4);
            dodawanie(10, 10);

            var klasa = new KlasaDoDelegata();
            Del e = klasa.Mnozenie;
            e(5, 5);

            Del f = klasa.Dzielenie;
            f(10, 2);

            // -------------------------------

            KlasaDruga kd = new KlasaDruga();
            DelegatNumerDwa delegatnumerdwaA = kd.metodaA;
            delegatnumerdwaA();

            DelegatNumerDwa delegatnumerdwaB = KlasaDruga.metodaB;
            delegatnumerdwaB();
             

            Console.ReadKey();
        }
    }
}

 