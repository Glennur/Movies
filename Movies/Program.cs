using Movies;
using System.Collections.Generic;
using System;

namespace Movies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            List<Actor> actors = new List<Actor>();

            actors.Add(new Actor("Keanu Reeves", 1964, "The Matrix"));
            actors.Add(new Actor("Laurence Fishburne", 1961, "The Matrix"));
            actors.Add(new Actor("Carrie-Anne Moss", 1967, "The Matrix"));
            actors.Add(new Actor("Bruce Willis", 1955, "Die Hard"));
            actors.Add(new Actor("Tom Hardy", 1977, "Mad Max: Fury Road"));
            actors.Add(new Actor("Charlize Theron", 1975, "Mad Max: Fury Road"));
            actors.Add(new Actor("Matthew McConaughey", 1969, "Interstellar"));
            actors.Add(new Actor("Anne Hathaway", 1982, "Interstellar"));
            actors.Add(new Actor("Ryan Gosling", 1980, "Blade Runner 2049"));
            actors.Add(new Actor("Harrison Ford", 1942, "Blade Runner 2049"));
            actors.Add(new Actor("Jonah Hill", 1983, "Superbad"));
            actors.Add(new Actor("Ralph Fiennes", 1962, "The Grand Budapest Hotel"));
            actors.Add(new Actor("Tony Revolori", 1996, "The Grand Budapest Hotel"));



            movies.Add(new Action("The Matrix", 136, 12));
            movies.Add(new Action("Die Hard", 132, 13));
            movies.Add(new Action("Mad Max: Fury Road", 120, 14));
            
            movies.Add(new SciFi("Interstellar", 169, 15));
            movies.Add(new SciFi("Blade Runner 2049", 164, 16));

            movies.Add(new Comedy("Superbad", 113, 300));
            movies.Add(new Comedy("The Grand Budapest Hotel", 99, 1));

            movies.Add(new Movie("Sunes Sommar", 98));
            

            foreach (Movie movie in movies)
            {
                Console.Write("Filmen " + movie.Title + " är " + movie.RunningTime + " minuter lång och har följande skådespelare: ");

                foreach (Actor actor in actors)
                    if (actor.Movie == movie.Title)
                    {
                        Console.Write(actor.Name + " (" + actor.YearOfBirth + "), ");
                    }                
                movie.TypeOfMovie();
                Console.WriteLine("------------------------------");
            }
        }
    }
}


