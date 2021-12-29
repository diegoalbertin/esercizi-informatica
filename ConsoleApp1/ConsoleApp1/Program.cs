using System;

namespace es2_polimorfismo
{
    class Program
    {
        class Veicoli
        {
            public int codVeicolo;
            public string tipo;
            public string marca;
            public string modello;
            public Veicoli(int codVeicolo, string tipo, string marca, string modello)
            {
                this.codVeicolo = codVeicolo;
                this.tipo = tipo;
                this.marca = marca;
                this.modello = modello;
            }
            public virtual double calcolaPrezzo()
            {
                return 5000;
            }
            public virtual int calcolaPrezzoKm()
            {
                return 0;
            }
            public override string ToString()
            {
                return $"codice:{codVeicolo}-tipo:{tipo}-marca:{marca}-modello:{modello}";
            }
        }
        class Auto : Veicoli
        {
            public Auto(int codVeicolo, string tipo, string marca, string modello) : base(codVeicolo, tipo, marca, modello)
            {
                this.codVeicolo = codVeicolo;
                this.tipo = tipo;
                this.marca = marca;
                this.modello = modello;
            }
            public override double calcolaPrezzo()
            {
                double prezzo = 5000 * (1.25);
                return prezzo;
            }
            public override int calcolaPrezzoKm()
            {
                return 5;
            }
        }
        class Furgone : Veicoli
        {
            public Furgone(int codVeicolo, string tipo, string marca, string modello) : base(codVeicolo, tipo, marca, modello)
            {
                this.codVeicolo = codVeicolo;
                this.tipo = tipo;
                this.marca = marca;
                this.modello = modello;
            }
            public override double calcolaPrezzo()
            {
                double prezzo = 5000 * (1.4);
                return prezzo;
            }
            public override int calcolaPrezzoKm()
            {
                return 10;
            }
        }
        static void Main(string[] args)
        {
            Auto automobile = new Auto(52416541, "suv", "plug", "saettaMQueen");
            Furgone furg = new Furgone(23151524, "furgon", "fiat", "portapecora");
            Console.WriteLine(automobile.ToString());
            Console.WriteLine(automobile.calcolaPrezzo() + "euro");
            Console.WriteLine(automobile.calcolaPrezzoKm() + "euro/km");
            Console.WriteLine(furg.ToString());
            Console.WriteLine(furg.calcolaPrezzo() + "euro");
            Console.WriteLine(furg.calcolaPrezzoKm() + "euro/km");
            Console.ReadLine();
        }
    }
}

