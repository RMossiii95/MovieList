using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList
{
    class Movie
    {
        public string MovieName { get; set; }

        public string Genre { get; set; }

        public Movie(string moviename, string genre)
        {
            this.MovieName = moviename;
            this.Genre = genre;
        }

        public void PrintMovie()
        {
            Console.WriteLine($"{this.MovieName} - {this.Genre}");
        }



    }
}
