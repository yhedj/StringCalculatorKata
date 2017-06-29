using System;
using System.Linq;

namespace SolidExercices
{
    public class Addition : IOperations
    {

        public bool CaractCalculate(String calcul)
        {
            return calcul.Contains('+');
        }

        public decimal Calculate(string calcul)
        {
            
                String[] nb = calcul.Split('+');
                var resultat = Convert.ToDecimal(nb[0]);
            foreach (var number in nb.Skip(1).ToArray())
                {
                    resultat += Convert.ToDecimal(number);
                }
                return resultat;
            
        }
    }
}