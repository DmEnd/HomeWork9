using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Смоделируйте работу простого калькулятора.Программа должна запрашивать 2 числа, а затем – код операции
             * (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное). После этого на консоль выводится ответ.
             * Используйте обработку исключений для защиты от ввода некорректных данных.
            */
            decimal a, b;
            a = b = 0;

            int n = 0;

            try
            {
                Console.WriteLine("Введите число 1-число");
                a = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Введите число 2-число");
                b = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Введите код операции:\n 1-сложение\n 2-вычитание\n 3-умножение\n 4-деление");
                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {

                    case 1:
                        {

                            Console.WriteLine("\n{0}+{1}={2}", a, b, a + b);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\n{0}-{1}={2}", a, b, a - b);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\n{0}*{1}={2}", a, b, a * b);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\n{0}/{1}={2}", a, b, a / b);
                            break;
                        }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("\nОшибка. {0}", ex.Message);
            }

            Console.ReadKey();
        }
    }
}
