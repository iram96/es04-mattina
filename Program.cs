/*
A partire dalla versione C# 3.0 (.NET 3.5) è stata introdotta la Object Initializer Syntax, 
un nuovo modo di inizializzare un oggetto di una classe o di una collection 
Questo nuovo modo ti permette di assegnare valori agli attributi al momento della 
creazione dell'istanza e senza invocare il costruttore.

Da notare la proprietà MATRICOLA dello studente (_myPropertyInternalMatricolaStudente)
Di questa variabile una parte la voglio tenere interna all'università (es. i primi 5 bytes)
mentre una parte (i secondi 5 bytes) la voglio rendere publica inclusi i tre bytes finali.

Esercizio: gestire il fatto che se StudentName non è impostato, allora non potrei impostare
tale proprietà. Allora metto i secondi 5 bytes a 0. E la set di StudentName completa l'operazione.

*/



namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Studente
    {
        private string sMatricolaStudente;
        //private string? quando nel costruttore è sMatri... = null;
        public string sCognomeStudente;

        public Studente()
        {
            this.sMatricolaStudente = null; //non occupa spazio di memoria
            sMatricolaStudente = "";
            sCognomeStudente = "";
        }

        public void SetMatricolaStudente(string sIdStudente)
        {
            this.sMatricolaStudente = "001" + sIdStudente;
        }
    }


    public class Contenuto
    {
        private int iDurataPausa;
        protected int DurataInMinuti; //accessibile solo dalla classe Serie
        public string titolo;

        public Contenuto(string titolo)
        {
            this.titolo = titolo;
            this.iDurataPausa = 10;
        }

        public virtual void Riproduci()
        {
            Console.WriteLine("Stai guardando " + titolo);
        }

    }

    public class Serie : Contenuto
    {
        private string[] cast;

        public Serie(string titolo, string[] cast) : base(titolo)
        {
            this.cast = cast;
        }

        public void ModificaDurata(int iNuovaDurata)
        {
            this.DurataInMinuti = iNuovaDurata;
        }

        public override void Riproduci()
        {
            Console.WriteLine("Stai guardando la Serie: " + titolo);
            base.Riproduci();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // EsempioUsoClassStudent MioStudente = new EsempioUsoClassStudent();
            // MioStudente.EsempioUsoClassStudent_Main();
            string[] MioCast = new string[3];
            MioCast[0] = "first actor";
            MioCast[1] = "second actor";
            MioCast[2] = "third actor";
            Serie MiaSerie = new Serie("DeadPool", MioCast);

            MiaSerie.titolo = "DeadPool 2";
            MiaSerie.Riproduci();
            MiaSerie.ModificaDurata(35);


        }
    }
}