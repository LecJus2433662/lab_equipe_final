using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesFilms
{
    public partial class Film
    {
        public string titre { get; set; }
        string directeur { get; set; }
        int anneeSortie { get; set; }
        public List<string> acteurs { get; set; }

        public Film(string titre, string directeur, int anneeSortie)
        {
            this.titre = titre;
            this.directeur = directeur;
            this.anneeSortie = anneeSortie;
            this.acteurs = new List<string>();
        }



        public override string ToString()
        {
            return $"Titre : {titre}, Directeur : {directeur} , anneeDeSortie : {anneeSortie}";
        }
    }

    public partial class Film
    {
        string genre; //a reverifier pour le nom
        List<string> genres;

        public Film(string genre)
        {
            this.genres = new List<string>();
        }

    }
}
