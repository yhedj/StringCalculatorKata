using System;
using System.Linq;

namespace SolidExercices
{
    public class Division : IOperations
    {

        public bool CaractCalculate(String calcul)
        {
            return calcul.Contains('/');
        }

        public decimal Calculate(string operation)
        {
            
                String[] nb = operation.Split('/');
                var resultat = Convert.ToDecimal(nb[0]);
            foreach (var number in nb.Skip(1).ToArray())
                {
                    resultat = resultat / Convert.ToDecimal(number);
                }
                return resultat;
            
        }
    }
}