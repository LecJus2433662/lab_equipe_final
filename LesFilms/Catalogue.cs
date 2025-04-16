using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesFilms
{
    public partial class Catalogue
    {
        List<Film> films { get; set; }

        public Catalogue()
        {
            films = new List<Film>();
        }

        
        public void AjouterFilm(Film film)
        {
            films.Add(film);
        }

        public void SupprimerFilm(Film film)
        {
            films.Remove(film);
        }

        private string AfficherFilms()
        {
            string afficher = "";
            foreach (Film filmAfficher in films)
            {
                afficher += filmAfficher + "\n";
            }
            return afficher;
        }

        public override string ToString()
        {
            return AfficherFilms();
        }

    }

    public partial class Catalogue
    {

        public void RechercherParActeur(string nomActeur)
        {
            bool rechercheActeur = false;
            foreach (Film film in films)
            {
                if (film.acteurs.Contains(nomActeur))
                {
                    Console.WriteLine($"Nom acetur : {nomActeur} -> film : {film.ToString()} \n");
                    rechercheActeur = true;
                }

            }
                if (!rechercheActeur)
                {
                    Console.WriteLine($"l'acteur {nomActeur} n'a pas de film pour l'instant.");
                }
        }

        public void RechercherParTitre(string nomTitre)
        {
            bool rechercheTitre = false;

            foreach (Film film in films)
            {
                if(nomTitre == film.titre)
                {
                    Console.WriteLine($"Nom titre : {nomTitre} -> film : {film.ToString()} \n");
                    rechercheTitre = true;
                }
            }
            if (!rechercheTitre)
            {
                    Console.WriteLine($"l'acteur {nomTitre} n'existe pas ou n'est pas encore sortie");
            }
        }

    }
}
