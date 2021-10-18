using System;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieDatabase MovieDb = new MovieDatabase();

            MovieDb.PrintMovie();
        }
    }
}
