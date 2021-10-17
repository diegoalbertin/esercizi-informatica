using System;

namespace esercio_5_difficile
{
    class temp
    {
        int puntatoreArray;
        static double max,min;
        static double[] temperatureCittà = new double[0];
        //costruttore
        public temp()
        {
        }
        //metodo che ritorna la temperatura maggiore
        public double tempMax()
        {
            max = temperatureCittà[temperatureCittà.Length - 1];
            return max;
        }
        //metodo che ritorna la temperatura minore
        public double tempMin()
        {
            min = temperatureCittà[0];
            return min;
        }
        //funzione che permette di ridimensionare l'array contenente le temperature
        static public void ridimensionaArray()
        {
            int lenghtArray;
            lenghtArray = temperatureCittà.Length;
            Array.Resize(ref temperatureCittà, (lenghtArray + 1));
        }
        static void Main(string[] args)
        {
            temp temperatura = new temp();
            string sceltaUtente = "si";
            while (sceltaUtente == "si" || sceltaUtente == "SI")//ciclo che permette l'inserimento delle temperature
            {
                Console.WriteLine("vuoi aggiungere una temperatura?");
                sceltaUtente = Console.ReadLine();
                if (sceltaUtente == "si" || sceltaUtente == "SI")
                {
                    Console.WriteLine("aggiungi la temperatura");
                    ridimensionaArray();
                    temperatureCittà[temperatureCittà.Length - 1] = Convert.ToDouble(Console.ReadLine());
                }
            }
            Array.Sort(temperatureCittà);//l'array contenente le temperature viene ordinato
            //vengono richiamati i metodi
            temperatura.tempMax();
            temperatura.tempMin();
            //avviene la stampa su schermo della temperatura maggiore e quella minore
            Console.WriteLine("la temperatura maggiore è: " + max);
            Console.WriteLine("la temperatura minore è: " + min);
            Console.ReadKey();
        }
    }
}
