using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestType
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            double a = 3, b = 4;

           

            Console.WriteLine("Привет");
            Console.WriteLine("Как тебя зовут?");
            string answer=Console.ReadLine();
            Console.WriteLine("Добро пожаловать в мою таверну, "+answer) ;
            Console.WriteLine("Что вы хотите выполнить?(Сложение(+),вычитание(-), умножение(*), деление(/).");
            string operation = Console.ReadLine();
            
            Console.WriteLine("Введите первое число");
            string num = Console.ReadLine();
            double.TryParse(num, out a);
            Console.WriteLine("Введите второе число");
            num = Console.ReadLine();
            double.TryParse(num, out b);
            if ("+" == operation) {
                Console.WriteLine("Sum " + (a + b));

            }
           else if ("-"== operation) { Console.WriteLine("Raz " + (a - b)); }
          else  if ("*"==operation)
            {
                Console.WriteLine("Umn " + (a * b));
            }
           else if ("/"==operation)
            {
                Console.WriteLine("Del " + (a / b));
            }

            
            Console.ReadLine(); 
        }
    }
}
