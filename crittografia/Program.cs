namespace crittografia
{
    internal class Program
    {
        //funzione crittografia cesare
        static char[] crittografia(char[] alfabeto, char[] parola, int key)
        {
            for(int i=0;i< parola.Length; i++) 
            { 
                int j = 0;
                while(parola[i]!= alfabeto[j])
                {
                    j++;
                }

                if (j + key >= alfabeto.Length)
                {
                    int saltifinali = key - (alfabeto.Length - j);
                    parola[i] = alfabeto[saltifinali];
                }
                else {parola[i] = alfabeto[j + key];}
            }

            return parola;
        }

        //funzione trasposizione 
        static char [] Trasposizione(char[] parola, int k)
        {
            char[] sostituzine= new char[parola.Length];
            for(int i = 0; i < parola.Length; i++)
            {
                parola[i] = sostituzine[(i + k) % parola.Length];
            }
            return parolaTrasposta;
        }

        //funzione decrittografia cesare
        static char[] decrittografia(char[] alfabeto, char[] parolaDec, int key2)
        {
            for (int i = 0; i < parolaDec.Length; i++)
            {
                int j = 0;
                while (parolaDec[i] != alfabeto[j])
                {
                    j++;
                }
                if (j - key2 < 0)
                {
                    int saltifinali = key2 - j;
                    parolaDec[i] = alfabeto[alfabeto.Length - saltifinali];
                }
                else { parolaDec[i] = alfabeto[j - key2]; }
            }
            return parolaDec;
        }
        static void Main(string[] args)
        {
            //crittografia cesare
            char[] alfabeto = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            int key;
            string parola;

            Console.WriteLine("Inserisci la chiave di crittografia (numero intero):");
            key = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci la parola da crittografare:");
            parola = Console.ReadLine();

            char[] parolaArray = parola.ToCharArray();
            Console.WriteLine();
            char []parolasostituita = crittografia(alfabeto, parolaArray, key);

            Console.WriteLine("Parola crittografata:");
            for (int i=0; i< parolasostituita.Length; i++)
            {
                Console.Write(parolasostituita[i]);
            }
            
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine();

            //decrittografia cesare
            string parolaDec;

            Console.WriteLine("Inserisci la chiave di decrittografia (numero intero):");
            int key2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci la parola da decrittografare:");
            parolaDec = Console.ReadLine();

            char[] parolaDecArray = parolaDec.ToCharArray();
            Console.WriteLine();
            char[] paroladecrittografata = decrittografia(alfabeto, parolaDecArray, key2);

            Console.WriteLine("Parola decrittografata:");
            for (int i = 0; i < paroladecrittografata.Length; i++)
            {
                Console.Write(paroladecrittografata[i]);
            }

            //trasposizione 
            string parola3;
            Console.WriteLine("Inserisci la parola :");



        }
    }
}
