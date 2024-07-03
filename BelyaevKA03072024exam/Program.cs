using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelyaevKA03072024exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double x, p, D; 
            double p_sum = 0, M = 0, D_sum = 0;
            int i = 5;
            while (i > 0)
            {
                try
                {
                    Console.Write("Введите размерность массива: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n <= 1) throw new Exception("Размерность массива должна быть больше 1");
                    double[,] input_m = new double[n, 2];
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("Введите x: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        input_m[j, 0] = x;
                        Console.Write("Введите p: ");
                        p = Convert.ToDouble(Console.ReadLine());
                        if (p < 0 || p > 1) throw new Exception("p должно быть в промежутке [0;1]");
                        p_sum += p;
                        M += x*p;
                        D_sum += Math.Pow(x, 2) * p;
                        input_m[j, 1] = p;
                    }
                    if (p_sum != 1) throw new Exception("Сумма всех вероятностей p должна равняться 1");
                    D = D_sum - Math.Pow(M, 2);

                    Console.WriteLine(n);
                    Console.WriteLine(M);
                    Console.WriteLine(D);

                    Console.WriteLine("Беляев");
                    Console.ReadLine();

                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                i--;
                Console.WriteLine($"У вас осталось {i} попыток.");
            }

            Console.WriteLine("У вас закончились попытки.");
            Console.WriteLine("В следующий раз сразу вводите допустимые значения.");
            Console.WriteLine("Беляев Константин Андреевич 31ИС");

        }
    }
}
