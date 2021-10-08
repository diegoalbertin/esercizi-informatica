//Dopo aver acquisito da tastiera una serie di prezzi relativi ai cellulari in vendita in un negozio,
//scrivere il codice di un programma(OOP) in C# che visualizzi i prezzi maggiori di 100€.
using System;

namespace esercizio_6
{
    class prezzi
    {
        static int nPrezzi;
        double p;
        double[] array1 = new double[nPrezzi];      
        public prezzi()
        {
        }
        public void inserimentoPrezzi()
        {
            for (int i = 0; i < nPrezzi; i++)
            {
                Console.WriteLine("inserisci il prezzo");
                p = Convert.ToDouble(Console.ReadLine());
                array1[i] = p;
            }
        }
        public void ordinamentoPrezzi()
        {
            int a=0;
            Array.Sort(array1);
            for (int i = 0; i < nPrezzi; i++)
            {
                if (array1[i] > 100)
                {
                    a++;
                }
            }
            Console.WriteLine("i prezzi maggiori di 100 euro sono {0}:",a);
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(array1[array1.Length-1-i]);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("quanti scontrini hai rilasciato");
            nPrezzi = Convert.ToInt32(Console.ReadLine());
            prezzi scontrini = new prezzi();
            scontrini.inserimentoPrezzi();
            scontrini.ordinamentoPrezzi();
        }
    }
}
