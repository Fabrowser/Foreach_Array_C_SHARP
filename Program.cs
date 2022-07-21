using System;

namespace teste_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] nomes = new string[] { "Fabricio", "tereza", "macaco" };// Array de nomes (string)

            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6 }; // Array de numeros

            foreach (string teste in nomes)
            {
                Console.WriteLine(teste);

            }

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);

            }
        }
    }
}
