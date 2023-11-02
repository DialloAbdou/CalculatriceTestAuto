using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcul
{
    public class CalculService
    {
        /// <summary>
        /// elle retourne la somme deux valeurs
        /// /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int addition(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// elle fait la soustraction
        /// des deux valeurs
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int soustration(int a, int b)
        {
            return (a - b);
        }

        /// <summary>
        ///  elle permet de multiplication
        ///  entre deuw valeurs
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Mulitiplication(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        // elle permet de faire la division
        // entre deux valeurs
        /// </summary>
        /// <param name="a"></param> 
        /// <param name="b"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int division(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Interdir de divser un nombre par Zero");
            }
            return a / b;
        }
    }
}
