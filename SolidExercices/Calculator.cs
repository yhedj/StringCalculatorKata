using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public double Calculate(string operation)
        {
            double resultat = 0;

            if (operation.Contains("+"))
            {
                String[] nb = operation.Split('+');
                
                foreach (var number in nb)
                {
                    resultat += Convert.ToDouble(number);
                }
                return resultat;

            }
            return resultat;

        }
    }
}