using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Movies
{
    internal class Movie
    {
        public string Title { get; set; }
        public int RunningTime { get; set; }

        public Movie(string title, int runningTime)
        {
            Title = title;
            RunningTime = runningTime;
        }

        public virtual void TypeOfMovie()
        {
            Console.WriteLine("Okända personer");
        }
    }
    internal class Actor
    {

        public List<Movie> Movies { get; set; } = new List<Movie>();
        public List<Actor> Actors { get; set; } = new List<Actor>();
        public string Name { get; set; }
        public int YearOfBirth { get; set; }
        public string Movie { get; set; }

        public Actor(string name, int yearOfBirth, string movie)
        {
            Name = name;
            YearOfBirth = yearOfBirth;
            Movie = movie;
        }
    }

    class Comedy : Movie
    {
        public int NumberOfFunnyScenes { get; set; }
        public Comedy(string title, int runningTime, int numberOfFunnyScenes) : base(title, runningTime) 
        {
            NumberOfFunnyScenes = numberOfFunnyScenes;
        }
        public override void TypeOfMovie()
        {
            Console.WriteLine("Filmen innehåller " + NumberOfFunnyScenes + " roliga scener.");
        }

    }
    class Action : Movie
    {
        public int NumberOfShotsFired { get; set; }
        public Action(string title, int runningTime , int numberOfShotsFired) : base(title, runningTime)
        {
            NumberOfShotsFired = numberOfShotsFired;
        }

        public override void TypeOfMovie()
        {
            Console.WriteLine("Filmen innehåller " + NumberOfShotsFired + " actionscener.");
        }

    }
    class SciFi : Movie
    {
        public int NumberOfSpaceShips { get; set; }
        public SciFi(string title, int runningTime, int numberOfSpaceShips) : base(title, runningTime)
        {
            NumberOfSpaceShips = numberOfSpaceShips;
        }
        public override void TypeOfMovie()
        {
            Console.WriteLine("Filmen innehåller " + NumberOfSpaceShips + " rymdskepp.");
        }

    }
}
