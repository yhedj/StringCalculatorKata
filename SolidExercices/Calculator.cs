using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            if (operation.Contains("+"))
            {
                String[] nb = operation.Split('+');
                var resultat = Convert.ToDecimal(nb[0]);

                foreach (var number in nb.Skip(1).ToArray())
                {
                    resultat += Convert.ToDecimal(number);
                }
                return resultat;
            }
            if(operation.Contains("-"))
            {
                String[] nb = operation.Split('-');
                var resultat = Convert.ToDecimal(nb[0]);

                foreach (var number in nb.Skip(1).ToArray())
                {
                    resultat = resultat - Convert.ToDecimal(number);
                }
                return resultat;
            }
            if (operation.Contains("*"))
            {
                String[] nb = operation.Split('*');
                var resultat = Convert.ToDecimal(nb[0]);

                foreach (var number in nb.Skip(1).ToArray())
                {
                    resultat = resultat * Convert.ToDecimal(number);
                }
                return resultat;
            }
            if (operation.Contains("/"))
            {
                String[] nb = operation.Split('/');
                var resultat = Convert.ToDecimal(nb[0]);

                foreach (var number in nb.Skip(1).ToArray())
                {
                    resultat = resultat / Convert.ToDecimal(number);
                }
                return resultat;
            }
            Console.WriteLine("L'opération n'est pas prit en charge !");
                return 0;
            }
    }
}