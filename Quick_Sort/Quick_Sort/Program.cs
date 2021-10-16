using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ordenamiento Quick Sort 
            Console.WriteLine("Lista de números");
            int[] lista = {40, 22, 7, 10, 77, 80, 96, 3, 14, 11};
            mostrar(lista);
            Console.ReadLine();
            Console.WriteLine("\n Números ordenados por medio del algoritmo Quick sort");
            Quicksort(lista, 0, lista.Length - 1);
            Console.ReadLine();
            Console.WriteLine("\n Números ordenados");
            mostrar(lista);
            Console.ReadLine();
        }

        static private void Quicksort(int[] lista, int inicio, int fin)
        {
            int x, y, varcentral;
            double pivote;
            varcentral = (inicio + fin) / 2;
            pivote = lista[varcentral];
            x = inicio;
            y = fin;

            do
            {   
                while (lista[x] < pivote) x++;
                while (lista[y] > pivote) y--;
                if (x <= y)
                {
                    int aux;
                    aux = lista[x];
                    lista[x] = lista[y];
                    lista[y] = aux;
                    x++;
                    y--;
                }
            } 
            while (x <= y);

            if (inicio < y)
            {
                Console.WriteLine();
                mostrar(lista);
                Quicksort(lista, inicio, y);
            }
            if (x < fin)
            {
                Quicksort(lista, x, fin);
            }
            Console.WriteLine();
            mostrar(lista);
        }

        private static void mostrar(int[] lista)
        {
            foreach (int i in lista)
                Console.Write(" " + i.ToString());
        }
    }
}
