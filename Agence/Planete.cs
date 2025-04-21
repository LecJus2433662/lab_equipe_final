using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
    public class Planete
    {
        string nom { get; set; }
        int taille { get; set; }
        int distanceTerre { get; set; }
        bool atmosphere { get; set; }
        bool exploree { get; set; }

        public Planete(string nom, int taille, int distanceTerre, bool atmosphere, bool explorer)
        {
            this.nom = nom;
            this.taille = taille;
            this.distanceTerre = distanceTerre;
            this.atmosphere = atmosphere;
            exploree = explorer;
        }

        public void Explorer()
        {
            try
            {
                if (exploree)
                {
                    throw new InvalidOperationException("Cette planète à déjà été explorer");
                }
                else
                {
                    
                    //t guez allo
                    exploree = true;
                    string rapport = "";
                    rapport += $"{nom} , {atmosphere}, {distanceTerre}, {taille}";
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
