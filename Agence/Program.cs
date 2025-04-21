using System;

namespace Agence
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
=======
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
            Console.WriteLine($"status de la mission : {mission.status}");

>>>>>>> 5c87c2466ace4cb48cc4e005ba9eec673cf0f2e6

        }
    }
}
