using System;

namespace pickme
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList moviesList = new MyList("movies to watch");
            moviesList.AddItem("The Prestige");
            moviesList.AddItem("Jumbo");
            moviesList.AddItem("Police Academy");
            moviesList.AddItem("Cleopatra");

            for (int i = 0; i < 4; i++)
            {
                ListItem pickedMovie = moviesList.Pick();
                if (pickedMovie == null) Console.WriteLine("You do not have any items in your list");
                Console.WriteLine(pickedMovie.Name);
            }
        }
    }
}
