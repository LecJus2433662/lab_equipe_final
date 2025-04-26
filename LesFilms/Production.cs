using LesFilms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesFilms
{
    public class Production
    {
        public Production()
        {
            Catalogue catalogue = new Catalogue();
            Film film1 = new Film("Minecraft", "Jack", 2025);
            Film film2 = new Film("StarWars", "Ben", 1999);
            Film film3 = new Film("Saw", "Fernand", 2024);

            film1.acteurs = new List<string> { "Benoit", "Jack Black", "Bernadette", "Gerald" };
            film2.acteurs = new List<string> { "Benoit", "Jean-Benoit", "Bernard", "Ferdinand" };
            film3.acteurs = new List<string> { "Louis", "Jean-Benoit", "Bernadette", "Gerald" };

            catalogue.AjouterFilm(film1);
            catalogue.AjouterFilm(film2);
            catalogue.AjouterFilm(film3);

            Console.WriteLine("Quel est le nom de l'acteur ?");
            string nomActeur = Console.ReadLine();
            catalogue.RechercherParActeur(nomActeur);

            Console.WriteLine("Quel est le titre du film ?"); 
            string nomTitre = Console.ReadLine();
            catalogue.RechercherParTitre(nomTitre);
        }
        
    }
}
