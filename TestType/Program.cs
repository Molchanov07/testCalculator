using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestType
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = 3, b = 4; 
            
            
            
            Console.WriteLine("Привет");
            Console.WriteLine("Как тебя зовут?");
            string answer=Console.ReadLine();
            Console.WriteLine("Добро пожаловать в мою таверну, "+answer) ;
            Console.WriteLine("Введите первое число");
            string num1 = Console.ReadLine();
            double.TryParse(num1, out a);
            Console.WriteLine("Введите второе число");
            string num2 = Console.ReadLine();
            double.TryParse(num2, out b);
            Console.WriteLine("Sum "+(a + b)) ;
            Console.WriteLine("Raz "+(a - b));
            Console.WriteLine("Umn "+(a * b));
            Console.WriteLine("Del "+ (a / b));
            Console.ReadLine(); 
        }
    }
}
