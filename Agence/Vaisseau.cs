using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
<<<<<<< HEAD

=======
   
>>>>>>> justin
    public partial class Vaisseau
    {
        public string Nom { get; set; }
        public int Capacite { get; set; }
        public double VitesseActuelle { get; set; }
        public double VitesseMax { get; set; }
        public bool EnOrbite;
        public List<Mission> missionsEnCours = new List<Mission>();


        public Vaisseau(string nom, int capacite, int vitesseActuelle, int vitesseMax)
        {
            this.Nom = nom;
            this.Capacite = capacite;
            this.VitesseActuelle = vitesseActuelle;
            this.VitesseMax = vitesseMax;
        }
        public void Decollage(string destination, DateTime dateDepart)
        {
            if (EnOrbite)
            {
                throw new Exception("Le vaisseau est déjà en orbite");
            }

            EnOrbite = true;
            Mission mission = new Mission($"Mission vers {destination}", destination, dateDepart, dateDepart.AddDays(180));
            missionsEnCours.Add(mission);
        }
        public override string ToString()
        {
            return $"nom vaisseau: {Nom}\n capacité de passager : {Capacite}\n vitesse actuelle : {VitesseActuelle}\n vitesse max : {VitesseMax}\n en orbite : {EnOrbite}";
        }
    }
}
