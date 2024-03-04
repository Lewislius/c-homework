using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个操作数：");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个操作数：");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入操作符：");
            string opcode = Console.ReadLine();
                switch (opcode)
                {
                    case "+":
                        Console.Write($"结果为:{num1 + num2}");
                        Console.Write("\n");
                        break;
                    case "-":
                        Console.Write($"结果为:{num1 - num2}");
                        Console.Write("\n");    
                        break;
                    case "*":
                        Console.Write($"结果为:{num1 * num2}");
                        Console.Write("\n");
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            Console.Write($"结果为:{num1 / num2}");
                            Console.Write("\n");
                        }
                        else
                        {
                            Console.WriteLine("输入错误:除数不能为0");
                            Console.Write("\n");
                        }
                        break;
                    default:
                        Console.WriteLine("操作符输入错误");
                        Console.Write("\n");
                        break;
                }

        }
    }
}
