using System;

namespace UnicamFattoriale
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            while (flag==0){
            //Stampo dei messaggi di cortesia per l'utente, così lo guido all'utilizzo del programma
            Console.WriteLine("Questo programma calcola il fattoriale di un numero");
            Console.Write("Digita un numero intero e premi invio (Per terminare digita 'U': ");

            //Console.ReadLine si mette in attesa che l'utente digiti qualcosa e prema invio.
            //Quando ha premuto invio, il testo che ha digitato lo assegno ad una variabile di tipo string.
            string testoDigitatoDallUtente = Console.ReadLine();
            if (testoDigitatoDallUtente=="U" || testoDigitatoDallUtente=="u"){break;}
            try{
            //Interpreto il testo come un numero intero
            //Attenzione: questa istruzione fallirà se l'utente ha digitato un testo
            //che non è interpretabile come un numero! (Es. ABCD)
            int numero = int.Parse(testoDigitatoDallUtente);
            if (numero<0){Console.WriteLine("Mi dispiace ma non posso calcolare il fattoriale per questo valore."); }
            else{
            //Calcolo il fattoriale: qui ci sono degli errori!
            int risultato = 1;
            int appoggio = numero;
            while (appoggio > 0) {
                risultato *= appoggio;
                appoggio--;
            }//while appoggio

            //Stampo il risultato
            Console.WriteLine($"Il fattoriale di {numero} e' {risultato}");
            //Attendo che l'utente prema un tasto prima di uscire, altrimenti 
            }//else
            }catch( Exception exc){
                Console.WriteLine("Mi dispiace ma non posso calcolare il fattoriale per questo valore.");
            }//catch
            Console.ReadKey();
            
            }//while flag
        }//main
    }//class
}//namespace
