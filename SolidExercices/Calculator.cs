using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public double? Calculate(string operation)
        {
            double resultat = 0;
            if (operation.Contains("+"))
            {
                String[] nb = operation.Split('+');             
                foreach (var number in nb.Skip(1).ToArray())
                {
                    resultat = Convert.ToDouble(nb[0]);
                    resultat += Convert.ToDouble(number);
                }
                return resultat;
            }
            else if(operation.Contains("-"))
            {
                String[] nb = operation.Split('-');
                foreach (var number in nb.Skip(1).ToArray())
                {
                    resultat = Convert.ToDouble(nb[0]);
                    resultat = resultat - Convert.ToDouble(number);
                }
                return resultat;
            }
            else if (operation.Contains("*"))
            {
                String[] nb = operation.Split('*');
                foreach (var number in nb.Skip(1).ToArray())
                {
                    resultat = Convert.ToDouble(nb[0]);
                    resultat = resultat * Convert.ToDouble(number);
                }
                return resultat;
            }
            else if (operation.Contains("/"))
            {
                String[] nb = operation.Split('/');
                foreach (var number in nb.Skip(1).ToArray())
                {
                    resultat = Convert.ToDouble(nb[0]);
                    resultat = resultat / Convert.ToDouble(number);
                }
                return resultat;
            }
            else
            {
                Console.WriteLine("L'opération n'est pas prit en charge !");
                return null;
            }

        }
    }
}