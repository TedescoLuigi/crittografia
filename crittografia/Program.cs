namespace crittografia
{
    internal class Program
    {
        static char[] crittografia(char[] alfabeto, char[] parola, int key)
        {
            for(int i=0;i< parola.Length; i++) 
            { 
                     for(int j=0; j< alfabeto.Length; j++)
                     {
                        if(parola[i] == alfabeto[j])
                        {
                            parola[i] = alfabeto[j + key];
                        }
                    
                     }

            }
           
            return parola;

        }
        static void Main(string[] args)
        {
            char[] alfabeto = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            int key ;
            string parola;

            Console.WriteLine("Inserisci la chiave di crittografia (numero intero):");
            key = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci la parola da crittografare:");
            parola = Console.ReadLine();

            char[] parolaArray = parola.ToCharArray();

             
            char []parolasostituita = crittografia(alfabeto, parolaArray, key);

            for(int i=0; i< parolasostituita.Length; i++)
            {
                Console.Write(parolasostituita[i]);
            }
            

        }
    }
}
