using System;

namespace SolidExercices
{
    public class CalculatorTrainer
    {
        private String[] _operations = new[] {"1+2,3", "2 * 3,6", "6-1+2.3", "ceci n'est pas une opération", "azert+1"};

        public void Run()
        {
            var calculator = new Calculator();
            foreach (var operation in _operations)
            {
                var resultat = calculator.Calculate(operation);
                Console.WriteLine(operation + " = " + resultat);
                
            }
        }

    }
}