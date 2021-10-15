using System;

namespace esercio_6
{
    class prezzi
    {
        static double[] arrayPrezziMagg = new double[0];
        public prezzi()
        {
        }
        public void controlloPrezzo(double prezzo)
        {
            int LenghtArray;
            if (prezzo > 100)
            {
                LenghtArray = arrayPrezziMagg.Length;
                Array.Resize(ref arrayPrezziMagg,(LenghtArray+1));
                arrayPrezziMagg[arrayPrezziMagg.Length-1] = prezzo;
            }
        }
        static void Main(string[] args)
        {
            string sceltaUtente = "SI";
            prezzi scontrino = new prezzi();
            double prezzo;
            while (sceltaUtente == "si" || sceltaUtente == "SI")
            {
                if(sceltaUtente == "si" || sceltaUtente == "SI")
                Console.WriteLine("vuoi aggiungere uno scontrino?");
                sceltaUtente = Console.ReadLine();
                Console.WriteLine("aggiungi il prezzo");
                prezzo = Convert.ToDouble(Console.ReadLine());
                scontrino.controlloPrezzo(prezzo);
            }
            Console.WriteLine("gli scontrini maggiori di 100 euro avevano come prezzo:");
            for (int i = 0; i < arrayPrezziMagg.Length; i++)
            {
                Console.WriteLine(arrayPrezziMagg[i]);
            }
            Console.ReadKey();
        }
    }
}
