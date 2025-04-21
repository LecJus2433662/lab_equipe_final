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
                if (nouvelleVitesse > vitesseMax)
                {
                    throw new InvalidOperationException("La vitesse demandée dépasse la vitesse maximale du vaisseau");
                }

                vitesseActuelle = nouvelleVitesse;
                Console.WriteLine($"Vitesse changée : {vitesseActuelle} km/h.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Erreur de changement de vitesse : {ex.Message}");
            }
        }
    }
}
