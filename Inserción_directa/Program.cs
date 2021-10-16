using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ordenamiento Inserción directa
            
            Console.WriteLine("Lista de números no ordenados");
            int[] lista = {38, 23, 54, 93, 12, 4, 21, 3, 95, 14, 53, 89, 78, 67};
            mostrar(lista);
            Console.WriteLine("");
            OrdenacionDirecta(lista);
            Console.ReadLine();
            Console.WriteLine("Lista de números ordenados por medio del algoritmo de inserción directa");
            mostrar(lista);
            Console.ReadLine();
        }

        public static void OrdenacionDirecta(int[] lista)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                int varaux = lista[i];
                int j = i - 1;
                while (j >= 0 && lista[j] > varaux)
                {
                    lista[j + 1] = lista[j];
                    j--;
                }lista[j + 1] = varaux;
            }
        }
        private static void mostrar(int[] lista)
        {
            foreach (int i in lista)
                Console.Write(" " + i.ToString());
        }
    }
}
