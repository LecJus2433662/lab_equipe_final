using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
    public class Planete
    {
        string Nom { get; set; }
        int Taille { get; set; }
        int DistanceTerre { get; set; }
        bool Atmosphere { get; set; }
        bool Exploree { get; set; }

        public Planete(string nom, int taille, int distanceTerre, bool atmosphere, bool explorer)
        {
            this.Nom = nom;
            this.Taille = taille;
            this.DistanceTerre = distanceTerre;
            this.Atmosphere = atmosphere;
            Exploree = explorer;
        }

        public void Explorer()
        {
            try
            {
                if (Exploree)
                {
                    throw new InvalidOperationException("Cette planète à déjà été explorer");
                }
                else
                {
                    
                   
                    Exploree = true;
                    string rapport = "";
                    rapport += $" nom planète : {Nom} , atmosphère : {Atmosphere}, distance à la terre : {DistanceTerre}, taille planète : {Taille}";
                    Console.WriteLine(rapport);
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Erreur lors de l'exploration de la planète : {ex.Message} ");
            }
        }
    }
}
