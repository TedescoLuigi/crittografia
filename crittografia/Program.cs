using System;

namespace crittografia
{
    internal class Program
    {
        // Funzione crittografia Cesare
        static char[] crittografia(char[] alfabeto, char[] parola, int key)
        {
            for (int i = 0; i < parola.Length; i++)
            {
                int j = 0;
                while (j < alfabeto.Length && parola[i] != alfabeto[j]) j++;

                if (j < alfabeto.Length)
                {
                    parola[i] = alfabeto[(j + key) % alfabeto.Length];
                }
            }
            return parola;
        }

        // Funzione decrittografia Cesare
        static char[] decrittografia(char[] alfabeto, char[] parolaDec, int key)
        {
            for (int i = 0; i < parolaDec.Length; i++)
            {
                int j = 0;
                while (j < alfabeto.Length && parolaDec[i] != alfabeto[j]) j++;

                if (j < alfabeto.Length)
                {
                    int index = (j - key) % alfabeto.Length;
                    if (index < 0) index += alfabeto.Length;
                    parolaDec[i] = alfabeto[index];
                }
            }
            return parolaDec;
        }

        // Funzione trasposizione (ciclo avanti)
        static char[] Trasposizione(char[] parola, int key)
        {
            char[] sostituzione = new char[parola.Length];
            int len = parola.Length;

            for (int i = 0; i < len; i++)
            {
                sostituzione[(i + key) % len] = parola[i];
            }

            return sostituzione;
        }

        // Funzione trasposizione inversa (ciclo indietro)
        static char[] TrasposizioneInversa(char[] parola, int key)
        {
            char[] sostituzione = new char[parola.Length];
            int len = parola.Length;

            for (int i = 0; i < len; i++)
            {
                sostituzione[i] = parola[(i + len - key) % len];
            }

            return sostituzione;
        }

        static void Main(string[] args)
        {
            char[] alfabeto = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            // --- Crittografia Cesare ---
            Console.WriteLine("Inserisci la chiave di crittografia Cesare (numero intero):");
            int keyCesare = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci la parola da crittografare:");
            string parola = Console.ReadLine();
            char[] parolaArray = parola.ToCharArray();

            char[] parolaCesare = crittografia(alfabeto, parolaArray, keyCesare);
            Console.WriteLine("Parola dopo crittografia Cesare: " + new string(parolaCesare));

            // --- Trasposizione sulla parola crittografata ---
            Console.WriteLine("Inserisci la chiave di trasposizione (numero intero):");
            int keyTrasposizione = Convert.ToInt32(Console.ReadLine());

            char[] parolaTrasposta = Trasposizione(parolaCesare, keyTrasposizione);
            Console.WriteLine("Parola dopo trasposizione: " + new string(parolaTrasposta));

            // --- Decifrazione inversa ---
            // Prima inverso trasposizione
            char[] parolaInversaTrasposizione = TrasposizioneInversa(parolaTrasposta, keyTrasposizione);
            // Poi decrittografia Cesare
            char[] parolaDecifrata = decrittografia(alfabeto, parolaInversaTrasposizione, keyCesare);

            Console.WriteLine("Parola decifrata: " + new string(parolaDecifrata));
        }
    }
}
