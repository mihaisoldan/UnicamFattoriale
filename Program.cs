using System;

namespace UnicamFattoriale
{
    class Program
    {
        const int MAX_NO = 12;
        static void Main(string[] args)
        {
            //Stampo dei messaggi di cortesia per l'utente, così lo guido all'utilizzo del programma
            Console.WriteLine("Questo programma calcola il fattoriale di un numero");
            do{
                Console.Write("Digita un numero e premi invio: ");

                //Console.ReadLine si mette in attesa che l'utente digiti qualcosa e prema invio.
                //Quando ha premuto invio, il testo che ha digitato lo assegno ad una variabile di tipo string.
                String testoDigitatoDallUtente = Console.ReadLine();
                //Interpreto il testo come un numero intero
                //Attenzione: questa istruzione fallirà se l'utente ha digitato un testo
                //che non è interpretabile come un numero! (Es. ABCD)
                int numero;
                bool isNumerical = int.TryParse(testoDigitatoDallUtente, out numero);
                if(!isNumerical || numero>MAX_NO || numero<0){
                    Console.WriteLine("Spiacente, non posso calcolare il fattoriale per questo valore.");
                    return ;
                }
                int temp = numero;
                //Calcolo il fattoriale: qui ci sono degli errori!
                int risultato = 1;
                while (numero > 0) {
                    risultato *= numero;
                    numero--;
                }

                //Stampo il risultato
                Console.WriteLine($"Il fattoriale di {temp} e' {risultato}");
                //Attendo che l'utente prema un tasto prima di uscire, altrimenti 
                
            }
            while(true);
            Console.ReadKey();

        }
        
    }
}
