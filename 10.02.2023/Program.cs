using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InPass = _10._02._2023.InternationalPassport;

namespace _10._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 2
            try 
            {
                Console.Write("Write boolean: ");
                string str = Console.ReadLine();
                string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int num1 = int.Parse(words[0]);
                int num2 = int.Parse(words[2]);

                bool result = false;
                switch (words[1])
                {
                    case "==": result = num1 == num2; break;
                    case "!=": result = num1 != num2; break;
                    case ">=": result = num1 >= num2; break;
                    case "<=": result = num1 <= num2; break;
                    case ">": result = num1 > num2; break;
                    case "<": result = num1 < num2; break;
                    default: throw new Exception("Unknown boolean action");
                }

                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadKey();
        }
    }
}
