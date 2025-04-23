using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
    public partial class Vaisseau
    {
        public void ChangerVitesse(double nouvelleVitesse)
        {
            try
            {
                if (nouvelleVitesse > VitesseMax)
                {
                    throw new InvalidOperationException("La vitesse demandée dépasse la vitesse maximale du vaisseau");
                }

                VitesseActuelle = nouvelleVitesse;
                Console.WriteLine($"Vitesse changée : {VitesseActuelle} km/h.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Erreur de changement de vitesse : {ex.Message}");
            }
        }
    }
}
