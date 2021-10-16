using System;

namespace Burbuja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números a ordenar ");
            int[] lista = { 39, 23, 43, 34, 35, 90, 1, 9, 10, 29, 45, 22, 100};
            mostrar(lista);
            Console.ReadLine();
            int x;
            for (int i = 1; i < lista.Length; i++)
                for(int j = lista.Length - 1; j >= i; j--)
                {
                    if(lista[j - 1] > lista[j])
                    {
                        x = lista[j - 1];
                        lista[j - 1] = lista[j];
                        lista[j] = x;
                    }
                }
            Console.WriteLine("Números ordenados con el método burbuja");
            mostrar(lista);
            Console.ReadLine();
        }
        private static void mostrar(int[] lista)
        {
            foreach (int i in lista)
                Console.Write(" " + i.ToString());
        }
    }
}
