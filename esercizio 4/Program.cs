/*creare un programma che dopo aver letto in imput il raggio di una circonferenza calcoli e visualizzi
il diametro, la circonferenza e l'area*/

using System;

namespace esercizio_4
{
    class circonferenza
    {
       

        double r;
        //costruttore
        public circonferenza()
        {
            r = 0;
        }
        //metodo per l'insrimento del raggio
        public void inserisciRaggio()
        {
            Console.WriteLine("inserisci il raggio");
            r = Convert.ToDouble(Console.ReadLine());
        }
        //metodo per il calcolo del diametro
        public void calcolaDiametro()
        {
            double diametro;
            diametro = r * 2;
            Console.WriteLine("il diametro è:" + diametro);
        }
        //metodo per il calcolo della circonferenza
        public void calcolaCirconferenza()
        {
            double circonferenza;
            circonferenza = r * 2 * Math.PI;
            Console.WriteLine("la circonferenza è:" + circonferenza);
        }
        //metodo per il calcolo dell'area
        public void calcolaArea()
        {
            double area;
            area = (Math.Pow(r, 2)) * Math.PI;
            Console.WriteLine("l'area è:" + area);
        }
        static void Main(string[] args)
        {
            //viene creata una nuova istanza della classe circonferenza
            circonferenza c = new circonferenza();
            //vengono richiamati i metodi della classe circonferenza
            c.inserisciRaggio();
            c.calcolaDiametro();
            c.calcolaCirconferenza();
            c.calcolaArea();
        }
    }
}
