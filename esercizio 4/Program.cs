/*creare un programma che dopo aver letto in imput il raggio di una circonferenza calcoli e visualizzi
il diametro, la circonferenza e l'area*/

using System;

namespace esercizio_4
{
    class circonferenza
    {
       

        double r;
        public circonferenza()
        {
            r = 0;
        }
        public void inserisciRaggio()
        {
            Console.WriteLine("inserisci il raggio");
            r = Convert.ToDouble(Console.ReadLine());
        }
        public void calcolaDiametro()
        {
            double diametro;
            diametro = r * 2;
            Console.WriteLine("il diametro è:" + diametro);
        }
        public void calcolaCirconferenza()
        {
            double circonferenza;
            circonferenza = r * 2 * Math.PI;
            Console.WriteLine("la circonferenza è:" + circonferenza);
        }
        public void calcolaArea()
        {
            double area;
            area = (Math.Pow(r, 2)) * Math.PI;
            Console.WriteLine("l'area è:" + area);
        }
        static void Main(string[] args)
        {
            circonferenza c = new circonferenza();
            c.inserisciRaggio();
            c.calcolaDiametro();
            c.calcolaCirconferenza();
            c.calcolaArea();
        }
    }
}
