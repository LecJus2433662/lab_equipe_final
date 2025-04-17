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

   
}
