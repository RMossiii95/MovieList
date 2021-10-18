using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList
{
    class Movie
    {
        public string Movies { get; set; }

        public string Genres { get; set; }

        public Movie(string Movies, string Genres)
        {
            this.Movies = Movies;
            this.Genres = Genres;
        }



    }
}
