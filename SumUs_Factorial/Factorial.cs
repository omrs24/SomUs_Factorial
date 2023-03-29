using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumUs_Factorial
{
    internal class Factorial
    {
        int InputInt;
        public Factorial(int num) 
        {
            this.InputInt = num;
        }

        public void GetFactorial()
        {
            // Variable para almacenar resultado de multiplicaciones
            int result = 1;

            // Comenzamos la salida
            Console.Write($" {InputInt}! = ");

            // Mostramos cada iteracion de InputInt hasta llegar a 1
            for (int i = InputInt; i > 0; i--)
            {
                // Multiplicar por cada iteracion 
                result *= i;

                Console.Write(i);

                // Al llegar a 1 mostramos el total de las multiplicaciones y salimos del loop
                if (i == 1)
                {
                    Console.Write($" = { result }");
                    break;
                }

                Console.Write(" x ");

            }

        }
    }
}
