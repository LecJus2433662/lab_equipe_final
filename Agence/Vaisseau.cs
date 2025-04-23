using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
    //allo test
    public partial class Vaisseau
    {
        public string nom { get; set; }
        public int capacite { get; set; }
        public double vitesseActuelle { get; set; }
        public double vitesseMax { get; set; }
        public bool enOrbite;
        public List<Mission> missionsEnCours = new List<Mission>();


        public Vaisseau(string nom, int capacite, int vitesseActuelle, int vitesseMax)
        {
            this.nom = nom;
            this.capacite = capacite;
            this.vitesseActuelle = vitesseActuelle;
            this.vitesseMax = vitesseMax;
        }
        public void Decollage(string destination, DateTime dateDepart)
        {
            if (enOrbite)
            {
                throw new Exception("Le vaisseau est déjà en orbite");
            }

            enOrbite = true;
            Mission mission = new Mission($"Mission vers {destination}", destination, dateDepart, dateDepart.AddDays(180));
            missionsEnCours.Add(mission);
        }
        public override string ToString()
        {
            return $"nom vaisseau: {nom}\n capacité de passager : {capacite}\n vitesse actuelle : {vitesseActuelle}\n vitesse max : {vitesseMax}\n en orbite : {enOrbite}";
        }
    }
}
