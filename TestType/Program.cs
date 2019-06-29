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
            //Создать калькулятор который для двух чисел выводит сумму, разность, деление, умножение в консоль с новой строки.
            double a = 3, b = 4, c;  
            
            Console.WriteLine("Введи число");
            Console.WriteLine("Введи знак");
           
            
            c = a + b;

            Console.WriteLine("Введи число");
            Console.Write("Sum:" + c);
d            Console.WriteLine ("Raz:" + (a - b));  
            
            Console.ReadLine(); 
        }
    }
}
