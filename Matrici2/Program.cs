using System;

namespace Matrici2
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Introduceti numarul de linii:");
            int N = Int32.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul de coloane:");
            int M = Int32.Parse(Console.ReadLine());

            int[,] matrix = new int[N, M];

            for (int row = 0; row < N; row++)
                for (int col = 0; col < M; col++)
                {
                    Console.Write($"[{row},{col}]");
                    matrix[row, col] = Int32.Parse(Console.ReadLine());
                }

            Console.Write("Introduceti linia pe care se va calcula suma:");
            int R = Int32.Parse(Console.ReadLine());
            Console.Write("Introduceti coloana pe care se va calcula suma:");
            int C = Int32.Parse(Console.ReadLine());

            int sumaR = 0;
            int sumaC = 0;

            for (int i = 0; i < N; i++)
            { sumaC = sumaC + matrix[i, R]; }

            for (int i = 0; i < M; i++)
            { sumaR = sumaR + matrix[R, i]; }

            Console.WriteLine($"Suma pe linia {R} este:"+sumaR);
            Console.WriteLine($"Suma pe coloana {C} este:"+sumaC);

        }
    }
}
