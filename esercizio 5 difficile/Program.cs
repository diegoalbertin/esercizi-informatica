using System;

namespace esercio_5_difficile
{
    class temperatura
    {
        static double[] arrayTemp1 = new double[1];//array utilizzati per l'archiviazione delle temperature
        static double[] arrayTemp2 = new double[0];
        static double min, max;//variabili utilizzate per il minimo e il massimo
        public temperatura()
        {
        }
        //metodo che restituisce la temperatura più grande
        public double tempMax()
        {
            if (arrayTemp1.Length > arrayTemp2.Length)
            {
                max =arrayTemp1[arrayTemp1.Length-1];
            }
            else if (arrayTemp2.Length > arrayTemp1.Length)
            {
                max =arrayTemp2[arrayTemp2.Length-1];
            }
            return max;
        }
        //metodo che restituisce la temperatura più piccola
        public double tempMin()
        {
            if (arrayTemp1.Length > arrayTemp2.Length)
            {
                min = arrayTemp1[0];
            }
            else if (arrayTemp2.Length > arrayTemp1.Length)
            {
                min = arrayTemp2[0];
            }
            return min;
        }
        static void Main(string[] args)
        {
            string rispostautente="SI";
            Console.WriteLine("aggiungi una temperatura");
            arrayTemp1[0] = Convert.ToDouble(Console.ReadLine());
            while(rispostautente == "si" || rispostautente == "SI")
            {
                Console.WriteLine("vuoi aggiungere una temperatura?");
                rispostautente = Console.ReadLine();
                if (rispostautente == "si" || rispostautente == "SI")
                {
                    if (arrayTemp1.Length > arrayTemp2.Length)
                    {
                        Array.Resize(ref arrayTemp2, (arrayTemp1.Length + 1));
                        for (int i = 0; i < arrayTemp1.Length; i++)
                        {
                            arrayTemp2[i] = arrayTemp1[i];
                        }
                        Console.WriteLine("aggiungi la temperatura");
                        arrayTemp2[arrayTemp1.Length - 1] = Convert.ToDouble(Console.ReadLine());
                    }
                    else if(arrayTemp2.Length > (arrayTemp1.Length))
                    {
                        Array.Resize(ref arrayTemp1, arrayTemp2.Length + 1);
                        for (int i = 0; i < arrayTemp2.Length; i++)
                        {
                            arrayTemp1[i] = arrayTemp2[i];
                        }
                        Console.WriteLine("aggiungi la temperatura");
                        arrayTemp1[arrayTemp2.Length - 1] = Convert.ToDouble(Console.ReadLine());
                    }
                }
            }
            if (arrayTemp1.Length > arrayTemp2.Length)
            {
                Array.Sort(arrayTemp1);
            }
            else if (arrayTemp2.Length > arrayTemp1.Length)
            {
                Array.Sort(arrayTemp2);
            }
            temperatura t = new temperatura();
            t.tempMax();
            t.tempMin();
            Console.WriteLine("la temperatura maggiore e':" + max);
            Console.WriteLine("la temperatura minore e':" + min);
            Console.ReadKey();
        }
    }
}
