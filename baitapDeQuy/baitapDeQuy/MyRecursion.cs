using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapDeQuy
{
    internal class MyRecursion
    {
        // tính giai thừa
        public int Factorial ( int n)
        {
            if (n == 0) return 1;
            else return n * Factorial(n - 1);
        }
        // tính lũy thừa
        public double LuyThua ( double a, double b )
        {
            if (b == 0) return 1;
            else return a * LuyThua(a, b - 1);
        }
        // fibonacci
        public int Fibonacci ( int n)
        {
            if (n == 1 || n == 2) return 1;
            else return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        // đảo ngược chuỗi
        public string Reverse( int n)
        {
            if (n == 0) return " ";
            else
            {
                Console.Write(n % 10);
                return Reverse(n / 10);
            }
        }
        // tính tổng các chữ số của 1 số nguyên
        public int SumDigits ( int n )
        {
            if (n == 0) return 0;
            return (n % 10) + SumDigits(n / 10);
        }
        // in dãy số từ 1 đến n bằng đệ quy
        public void Print1ToN( int n)
        {
            if (n == 0) return;
            Print1ToN(n - 1);
            Console.Write(n + " ");
        }
    }
}
