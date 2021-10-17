using System;

namespace esercio_6
{
    class prezzi
    {
        static double[] arrayPrezziMagg = new double[0];
        //costruttore
        public prezzi()
        {
        }
        //metodo che si occupa di controllare se i prezzi inseriti sono maggiori di 100euro
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
        public void stampaPrezzi()
        {
            Console.WriteLine("gli scontrini maggiori di 100 euro avevano come prezzo:");
            for (int i = 0; i < arrayPrezziMagg.Length; i++)
            {
                Console.WriteLine(arrayPrezziMagg[i]);
            }
        }
        static void Main(string[] args)
        {
            string sceltaUtente = "SI";
            prezzi scontrino = new prezzi();
            double prezzo;
            while (sceltaUtente == "si" || sceltaUtente == "SI")//ciclo che permette l'inserimento dei prezzi
            {
                Console.WriteLine("vuoi aggiungere uno scontrino?");
                sceltaUtente = Console.ReadLine();
                if (sceltaUtente == "si" || sceltaUtente == "SI")
                {
                    Console.WriteLine("aggiungi il prezzo");
                    prezzo = Convert.ToDouble(Console.ReadLine());
                    scontrino.controlloPrezzo(prezzo);//metodo relativo alla classe prezzi 
                }
            }
            scontrino.stampaPrezzi();//metodo relativo alla classe prezzi 
            Console.ReadKey();
        }
    }
}
