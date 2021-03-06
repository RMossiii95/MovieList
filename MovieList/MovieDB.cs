using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList
{
    class MovieDatabase
    {
        public List<Movie> ToWatch { get; set; } = new List<Movie>();

        public MovieDatabase()
        {
            ToWatch.Add(new Movie("Alien", "Horror"));
            ToWatch.Add(new Movie("Avatar", "SciFi"));
            ToWatch.Add(new Movie("Avengers: Endgame", "Action"));
            ToWatch.Add(new Movie("Blade Runner", "Noir"));
            ToWatch.Add(new Movie("Fight Club", "Noir"));
            ToWatch.Add(new Movie("Jacob's Ladder", "Horror"));
            ToWatch.Add(new Movie("Memento", "Noir"));
            ToWatch.Add(new Movie("Saving Private Ryan", "Action"));
            ToWatch.Add(new Movie("Star Trek", "SciFi"));
            ToWatch.Add(new Movie("Star Wars", "SciFi"));
    
        }

        public void PrintMoviesByGenre(string genre)
        {
            foreach (Movie x in ToWatch)
            {
                if(x.Genre == genre) 
                {
                    x.PrintMovie();
                }


            }
        }

        //public void PrintAllMovies()
        //{
        //    for (int i = 0; i < ToWatch.Count; i++)
        //    {
        //        Movie m = ToWatch[i];
        //        Console.WriteLine($"{i} : {m.MovieName}");

        //    }
        //    Console.WriteLine();
        //}
        

        

    }
}
