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
            
            
            c = a + b;

            Console.Write("Sum:" + c);
            Console.WriteLine ("Raz:" + (a - b));  
            
            Console.ReadLine(); 
        }
    }
}
