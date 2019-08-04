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


            double a = 0, b = 0;

            Console.WriteLine("Привет");
            Console.WriteLine("Как тебя зовут?");
            string creator = Console.ReadLine();
            if ("Юра" == creator || "Рома" == creator) {
                Console.WriteLine("Добро пожаловать, создатель" + creator); }
            else {
                Console.WriteLine("Добро пожаловать в мою таверну, " + creator);
            }
            Console.WriteLine("Что вы хотите выполнить?(Сложение(+),вычитание(-), умножение(*), деление(/).");
            string operation = Console.ReadLine();
            if (PrintErorMessage(operation, "Почему ты не ввел(а) знак?"))
            {
                return;
            }
            Console.WriteLine("Введите первое число");
            
            string num = Console.ReadLine();
            if (PrintErorMessage(num, "Почему ты не ввел(а) число?"))
            {
                return;
            }
            double.TryParse(num, out a);
            Console.WriteLine("Введите второе число");
            num = Console.ReadLine();
            if (PrintErorMessage(num, "Почему ты не ввел(а) число?"))
            {
                return;
            }
            double.TryParse(num, out b);
            if ("+" == operation)
            {
                Console.WriteLine("Sum " + (a + b));

            }
            else if ("-" == operation)
            {
                Console.WriteLine("Raz " + (a - b));
            }
            else if ("*" == operation)
            {
                Console.WriteLine("Umn " + (a * b));
            }
            else if ("/" == operation)
            {
                if (b == 0) { Console.WriteLine("Операция невозможна"); }
                                                         
                else { Console.WriteLine("Del " + (a / b));
                }

            }

            Console.ReadLine();
        }
        public static bool PrintErorMessage(string operation,string text  )
        {
            if (string.IsNullOrEmpty(operation))
            {
                Console.WriteLine(text);
                Console.WriteLine("Я не могу работать в таких условиях! Прощай, встретимся в таверне позже");
                Console.ReadLine(); return true;
                
                
            }else { return false; }
        }
    }
}
