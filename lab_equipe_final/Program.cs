﻿using System;
using System.Linq.Expressions;

namespace lab_equipe_final
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Calculateur multiplicateur = new Calculateur();
                int nombre1 = 0;
                int nombre2 = 0;
                Console.WriteLine("calculatrice a multiplication");
                Console.WriteLine("entrez un nombre");
                nombre1 = int.Parse(Console.ReadLine());
                Console.WriteLine("entrez un autre nombre");
                nombre2 = int.Parse(Console.ReadLine());
                Console.WriteLine("le résultat de la multiplication est :");

                checked
                {
                    Console.WriteLine(multiplicateur.Multiplication(nombre1, nombre2));
                }
            }
            catch(OverflowException e)
            {
                Console.WriteLine("ce n'est pas un nombre, donc pas de bras, pas de chocolat");
            }
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
