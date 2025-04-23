using System;


/**********************************************/
/*  Nom :   justin leclerc, Alexis Turcotte
    Date : 2025-04-23
    Description : mission spatiale 


    Probleme rencontre :   problème avec github (conflit)
    

    Review par : Olesksander
*/
/**********************************************/
namespace Agence
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Vaisseau vaisseau = new Vaisseau("le vaisseau", 50, 500, 2500);
            Mission mission = new Mission("vers mars","mars",DateTime.Now,DateTime.Now.AddDays(45));

            Planete terre = new Planete("terre",200000,0,true,false);
            Planete mars = new Planete("mars",189000,50000,false,false);

            Console.WriteLine("test de décollage");
            vaisseau.Decollage("mars",DateTime.Now);



            Console.WriteLine("test de changement de vitesse 1");
            vaisseau.ChangerVitesse(1500);


            Console.WriteLine("\ntest de changement de vitesse 2");
            vaisseau.ChangerVitesse(5000);
            Console.WriteLine();
            terre.Explorer();
            Console.WriteLine();
            terre.Explorer();
            Console.WriteLine();
            mars.Explorer();

            Console.WriteLine("\n complétion de la mission.... ");
            mission.CompleterMission();
            Console.WriteLine($"status de la mission : {mission.Status}");


        }
    }
}
