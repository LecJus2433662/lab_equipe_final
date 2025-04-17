using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesFilms
{
    public partial class Film
    {
        string synopsys;
        List<string> genres;

        public Film(string genre)
        {
            this.genres = new List<string>();
        }
    }
}