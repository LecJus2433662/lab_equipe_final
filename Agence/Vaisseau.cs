using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
    public partial class Vaisseau
    {
        public string nom { get; set; }
        public int capacite { get; set; }
        public double vitesseActuelle { get; set; }
        public double vitesseMax { get; set; }
        private bool enOrbite;
        private List<Mission> missionsEnCours = new List<Mission>();


        public Vaisseau(string nom, int capacite, int vitesseActuelle, int vitesseMax, bool enOrbite)
        {
            this.nom = nom;
            this.capacite = capacite;
            this.vitesseActuelle = vitesseActuelle;
            this.vitesseMax = vitesseMax;
            this.enOrbite = enOrbite;
        }
        public void Decollage(int x, int y, DateTime date)
        {
            try
            {
                if (enOrbite)
                {
                    throw new InvalidOperationException("Le vaisseau est déjà en orbite");
                }
                enOrbite = true;
                Console.WriteLine($"Décollage en orbite");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"erreur lors du décollage : {ex.Message}");
            }
        }
    }
}
