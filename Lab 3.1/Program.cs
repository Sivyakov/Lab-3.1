using System;

namespace Lab_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.1 средний уровень вариант 15
            try
            {
                Console.WriteLine("Введите число k:");
                int k = int.Parse(Console.ReadLine());
                double S = 0;
                for (int n = 1; n <= k + 1; n++)
                {
                    if (n == 1) continue;
                    S += Math.Pow(-1, 2 * n) * (n * n - 9) * (n * n - 9) / (3 * n)!;
                }
                Console.WriteLine($"Y={S:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
