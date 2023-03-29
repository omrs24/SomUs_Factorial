using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumUs_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un numero para saber su factorial: ");

            int result = GetInputInteger();

            Factorial factorial = new Factorial(result);

            factorial.GetFactorial();

            // Para que no cierre el programa
            Console.ReadLine();

        }

        public static int GetInputInteger() 
        {
            int inputint = 0;

            // Validacion Int
            while(!int.TryParse(Console.ReadLine(),out inputint));

            return inputint; 
        }
    }
}
