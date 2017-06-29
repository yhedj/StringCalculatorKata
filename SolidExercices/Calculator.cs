using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            IOperations addition = new Addition();

            if (addition.CaractCalculate(operation))
            {
                return addition.Calculate(operation);
            }

            IOperations soustraction = new Soustraction();
            if(soustraction.CaractCalculate(operation))
            {
                return soustraction.Calculate(operation);
            }
            IOperations multiplication = new Multiplication();
            if (multiplication.CaractCalculate(operation))
            {
                return multiplication.Calculate(operation);
            }

            IOperations division = new Division();
            if (division.CaractCalculate(operation))
            {   return division.Calculate(operation);
            }
            Console.WriteLine("L'opération n'est pas prit en charge !");
                return 0;
            }
    }
}