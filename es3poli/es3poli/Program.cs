using System;

namespace es2_polimorfismo
{
    class Program
    {
        class aerei
        {
            public int codaereo;
            public string tipo;
            public string nome;
            public aerei(int codaereo, string tipo, string nome)
            {
                this.codaereo = codaereo;
                this.tipo = tipo;
                this.nome = nome;
            }
            public virtual double calcolaPrezzo()
            {
                return 5000000;
            }
            public virtual int calcolaPrezzoKm()
            {
                return 0;
            }
            public override string ToString()
            {
                return $"codice:{codaereo}-tipo:{tipo}-nome:{nome}";
            }
        }
        class cargo : aerei
        {
            public cargo(int codaereo, string tipo, string nome) : base(codaereo, tipo, nome)
            {
                this.codaereo = codaereo;
                this.tipo = tipo;
                this.nome = nome;
            }
            public override double calcolaPrezzo()
            {
                double prezzo = 5000 * (1.35);
                return prezzo;
            }
            public override int calcolaPrezzoKm()
            {
                return 500;
            }
        }
        class passeggeri : aerei
        {
            public passeggeri(int codaereo, string tipo, string nome) : base(codaereo, tipo, nome)
            {
                this.codaereo = codaereo;
                this.tipo = tipo;
                this.nome = nome;
            }
            public override double calcolaPrezzo()
            {
                double prezzo = 5000 * (1.45);
                return prezzo;
            }
            public override int calcolaPrezzoKm()
            {
                return 750;
            }
        }
        static void Main(string[] args)
        {
            cargo cargo = new cargo(52416541, "suv", "plug");
            passeggeri passeggeri = new passeggeri(23151524, "furgon", "fiat");
            Console.WriteLine(cargo.ToString());
            Console.WriteLine(cargo.calcolaPrezzo() + "euro");
            Console.WriteLine(cargo.calcolaPrezzoKm() + "euro/km");
            Console.WriteLine(passeggeri.ToString());
            Console.WriteLine(passeggeri.calcolaPrezzo() + "euro");
            Console.WriteLine(passeggeri.calcolaPrezzoKm() + "euro/km");
            Console.ReadLine();
        }
    }
}

