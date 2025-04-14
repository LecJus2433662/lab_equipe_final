using System;
using System.Linq.Expressions;

namespace lab_equipe_final
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                
                Calculateur calculateur = new Calculateur();
                int nombre1 = 0;
                int nombre2 = 0;
                Console.WriteLine("Entrez un premier nombre à diviser");
                nombre1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Entrez un deuxième nombre à diviser");
                nombre2 = int.Parse(Console.ReadLine());
                calculateur.Division(nombre1, nombre2);
                Console.WriteLine("Le resultat de la division est :");
                Console.WriteLine(calculateur.Division(nombre1, nombre2));

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine();
                Console.WriteLine("T vrm guez utilise une calcu a place");
            }
            
        }
    }
}
