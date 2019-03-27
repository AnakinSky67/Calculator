using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Method
    {
        public int a, b, c, d;
        public int methodone(int a, int b, int c)
        {
            return a + b - c;
        }
        public int methodtwo(int a, int b, int c, int d)
        {
            return a * b + c / d;
        }
        public int methodthree(int a, int b, int c)
        {
            return a - b / c;
        }
        public int methodfour(int a, int b, int c, int d)
        {
            return a / b + c - d;
        }
        public int methodfive(int a, int b, int c)
        {
            return a + b * c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入需要的计算题个数");
            Random random = new Random();
            Method method = new Method();
            int result;
            int y;
            y = int.Parse(Console.ReadLine());
            for (int i = 0; i < y; i++)
            {
                int a = random.Next(1, 100);
                int b = random.Next(1, 100);
                int c = random.Next(1, 100);
                int d = random.Next(1, 100);
                int x = random.Next(1, 6);
                switch (x)
                {
                    case 1:
                        result = method.methodone(a, b, c);
                        Console.WriteLine("{0}+{1}-{2}={3}", a, b, c, result);
                        break;
                    case 2:
                        result = method.methodtwo(a, b, c, d);
                        Console.WriteLine("{0}*{1}+{2}/{3}={4}", a, b, c, d, result);
                        break;
                    case 3:
                        result = method.methodthree(a, b, c);
                        Console.WriteLine("{0}-{1}/{2}={3}", a, b, c, result);
                        break;
                    case 4:
                        result = method.methodfour(a, b, c, d);
                        Console.WriteLine("{0}/{1}+{2}-{3}={4}", a, b, c, d, result);
                        break;
                    case 5:
                        result = method.methodfive(a, b, c);
                        Console.WriteLine("{0}+{1}*{2}={3}", a, b, c, result);
                        break;
                }
            }
            Console.Read();
        }
    }
}
