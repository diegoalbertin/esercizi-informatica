using System;

namespace esercio_5
{
    class temp
    {
        double[] temperatureCittà = new double[0];
        //costruttore
        public temp()
        {
        }
        //metodo per l'inserimento delle temperature
        public void inserimentoTemp()
        {
            string sceltaUtente = "si";

            while (sceltaUtente == "si" || sceltaUtente == "SI")
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
        }
        //metodo che permette di ridimensionare l'array contenente le temperature
        public void ridimensionaArray()
        {
            int lenghtArray;
            lenghtArray = temperatureCittà.Length;
            Array.Resize(ref temperatureCittà, (lenghtArray + 1));
        }
        //metodo che effettua l'ordinamneto dell'array contenente le temperature
        public void ordinamentoTemperature()
        {
            Array.Sort(temperatureCittà);
        }
        //metodo che permette la visualizzazione su schermo della temperatura maggiore e quella minore
        public void stampaTemperature()
        {
            Console.WriteLine("la temperatura maggiore è: "+ temperatureCittà[temperatureCittà.Length-1]);
            Console.WriteLine("la temperatura minore è: "+temperatureCittà[0]);
        }
        static void Main(string[] args)
        {
            //viene creata una nuova istanza della classe temp
            temp temperatura = new temp();
            //vengono richiamati i metodi relativi a temp 
            temperatura.inserimentoTemp();
            temperatura.ordinamentoTemperature();
            temperatura.stampaTemperature();
            Console.ReadKey();
        }
    }
}
