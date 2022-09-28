using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nВведи положительное число.");
            while (true)
            {
                int neprostoe;
                int nepr_mal = 0;
                int nepr_bol = 0;
                Console.Write("  Вводить число здесь: ");
                neprostoe = int.Parse(Console.ReadLine());
                while (true)
                {
                    if (neprostoe == 0 || neprostoe < 0)
                    {
                        Console.WriteLine("Введите положительное число.");
                        break;
                    }
                    if (neprostoe > 0)
                    {
                        if (IsPrimeNumber(neprostoe))
                        {
                            Console.WriteLine("Введено простое число: " + neprostoe + "\n");
                            break;
                        }
                        for (int i = 1; i < neprostoe; i++)
                        {
                            if (IsPrimeNumber(i))
                            {
                                nepr_mal = i;
                            }
                        }
                        for (int j = neprostoe + 1; ; j++)
                        {
                            if (IsPrimeNumber(j))
                            {
                                nepr_bol = j;
                                break;
                            }
                        }
                        if ((neprostoe - nepr_mal) < (nepr_bol - neprostoe))
                        {
                            Console.WriteLine("Ближайшее просто число меньше введённого: " + nepr_mal + "\n");
                            break;
                        }
                        if ((neprostoe - nepr_mal) > (nepr_bol - neprostoe))
                        {
                            Console.WriteLine("Ближайшее простое число больше введённого: " + nepr_bol + "\n");
                            break;
                        }
                        if ((neprostoe - nepr_mal) == (nepr_bol - neprostoe))
                        {
                            Console.WriteLine("Ближайших чисел два: " + nepr_bol + " " + nepr_mal + "\n");
                            break;
                        }
                        break;
                    }
                    break;
                }
            }
        }
        static bool IsPrimeNumber(int neprostoe)
        {
            for (int i = 2; i < neprostoe; i++)
            {
                if (neprostoe % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}