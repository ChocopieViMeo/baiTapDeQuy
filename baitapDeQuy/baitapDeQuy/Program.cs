using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapDeQuy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyRecursion rec = new MyRecursion();
            int choice = -1;
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                Console.WriteLine("=============================");
                Console.WriteLine("1. Tính Giai Thừa ");
                Console.WriteLine("2.Tính Lũy Thừa ");
                Console.WriteLine("3. Tính Fibonacci ");
                Console.WriteLine("4. Đảo ngược chuỗi ");
                Console.WriteLine("5. Tính tổng chữ số của 1 số nguyên ");
                Console.WriteLine("6. In dãy từ 1 đến N"); ;
                Console.WriteLine("==============================");
                choice = int.Parse(Console.ReadLine());
                switch ( choice)
                {
                    case 1:
                        {
                            Console.Write(" Nhập n: ");
                            int n = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Giai thừa của {n} là : {rec.Factorial(n)}"); 
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Nhập số a: ");
                            int a = int.Parse(Console.ReadLine());
                            Console.Write("Nhập số b: ");
                            int b = int.Parse(Console.ReadLine());
                            Console.WriteLine($"{a} ^ {b} = {rec.LuyThua(a, b)}");
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Nhập số n: ");
                            int n = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Fibonacci {n} = {rec.Fibonacci(n)}");
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Nhập n: ");
                            int n = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Sau khi đảo chuỗi : {rec.Reverse(n)}");
                            break;
                        }
                    case 5:
                        {
                            Console.Write("Nhập số nguyên n: ");
                            int n = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Tổng {n} : {rec.SumDigits(n)}");
                            break;
                        }
                    case 6:
                        {
                            Console.Write("Nhập số n: ");
                            int n = int.Parse(Console.ReadLine());
                            Console.WriteLine($"In từ 1 đến {n} : ");
                            rec.Print1ToN(n);
                            break;
                        }
                }

            } while (choice != 0);

        }
    }
}
