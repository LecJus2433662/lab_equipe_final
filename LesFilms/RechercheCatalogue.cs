using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesFilms
{
    public partial class Catalogue
    {

        public void RechercherParActeur(string nomActeur)
        {
            bool rechercheActeur = false;
            foreach (Film film in films)
            {
                if (film.acteurs.Contains(nomActeur))
                {
                    Console.WriteLine($"Nom acteur : {nomActeur} -> film : {film.ToString()} \n");
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
                if (nomTitre == film.titre)
                {
                    Console.WriteLine($"Nom titre : {nomTitre} -> film : {film.ToString()} \n");
                    rechercheTitre = true;
                }
            }
            if (!rechercheTitre)
            {
                Console.WriteLine($"Le film {nomTitre} n'existe pas ou n'est pas encore sortie");
            }
        }

    }
}
