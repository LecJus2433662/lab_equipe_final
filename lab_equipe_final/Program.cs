using System;

namespace lab_equipe_final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Calculateur calculateur = new Calculateur();
                double nombre1 = 0;
                double nombre2 = 0;
                Console.WriteLine("Entrez un premier nombre à diviser");
                nombre1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Entrez un deuxième nombre à diviser");
                nombre2 = double.Parse(Console.ReadLine());
                calculateur.Division(nombre1, nombre2);
                Console.WriteLine("Le resultat de la division est :");
                Console.WriteLine(calculateur.Division(nombre1, nombre2));
            }
            catch (Exception ex)
            {
                Console.WriteLine("T vrm guez utilise une calcu a place");
            }
            

        }
    }
}
