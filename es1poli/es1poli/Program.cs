/*Si crei la classe dipendente con i soli attributi: matricola, nome e cognome. La classe avrà un
metodo che calcola la retribuzione oraria. Dalla nostra classe dipendente vogliamo derivare tre
differenti classi: dirigente, impiegato e operaio. Visualizzare la retribuzione oraria dei tre dipendenti
sapendo che la retribuzione oraria per l’operario è 35€/h mentre per l’impiegato la retribuzione
aumenta del 30% e per il dirigente del 50%.*/
using System;

namespace es_polimorfismo
{
    class Program
    {
        class dipendente
        {
            protected int matricola;
            public string nome;
            public string cognome;
            public dipendente(int matricola, string nome, string cognome)
            {
                this.matricola = matricola;
                this.nome = nome;
                this.cognome = cognome;
            }
            public virtual string calcolaRetribuzioneOraria()
            {
                return "";
            }
            public override string ToString()
            {
                return $"matricola:{matricola}-nome:{nome}-cognome:{cognome}";
            }
        }
        class dirigente : dipendente
        {
            public dirigente(int matricola, string nome, string cognome) : base(matricola, nome, cognome)
            {
                this.matricola = matricola;
                this.nome = nome;
                this.cognome = cognome;
            }
            public override string calcolaRetribuzioneOraria()
            {
                int retribuzione = 35 + 35 * 50 / 100;
                string retribuzioneOraria = Convert.ToString(retribuzione) + " euro/h";
                Console.WriteLine("" + retribuzioneOraria);
                return retribuzioneOraria;
            }
        }
        class operaio : dipendente
        {
            public operaio(int matricola, string nome, string cognome) : base(matricola, nome, cognome)
            {
                this.matricola = matricola;
                this.nome = nome;
                this.cognome = cognome;
            }
            public override string calcolaRetribuzioneOraria()
            {
                Console.WriteLine("35 euro/h");
                return "35 euro/h";
            }
        }
        class impiegato : dipendente
        {
            public impiegato(int matricola, string nome, string cognome) : base(matricola, nome, cognome)
            {
                this.matricola = matricola;
                this.nome = nome;
                this.cognome = cognome;
            }
            public override string calcolaRetribuzioneOraria()
            {
                int retribuzione = 35 + 35 * 30 / 100;
                string retribuzioneOraria = Convert.ToString(retribuzione) + " euro/h";
                Console.WriteLine("" + retribuzioneOraria);
                return retribuzioneOraria;
            }
        }

        static void Main(string[] args)
        {
            dirigente dirigente = new dirigente(777, "chiello", "fsk");
            operaio operaio = new operaio(8990, "taxi", "b");
            impiegato impiegato = new impiegato(098767568, "sapobully", "4l");
            Console.WriteLine(dirigente.ToString());
            dirigente.calcolaRetribuzioneOraria();
            Console.WriteLine(operaio.ToString());
            operaio.calcolaRetribuzioneOraria();
            Console.WriteLine(impiegato.ToString());
            impiegato.calcolaRetribuzioneOraria();
            Console.ReadKey();
        }
    }
}

