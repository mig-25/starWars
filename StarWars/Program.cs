using System;

namespace get_set_ex
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("________________________");
            Console.WriteLine();
            Console.WriteLine("Hello Star Wars Fans!");
            Console.WriteLine("________________________");
            Console.WriteLine();

            
            star_wars_figures movies = new star_wars_figures();
            

            movies.ListOfStarWarMovies();

            Console.WriteLine("________________________");
            Console.WriteLine();

            star_wars_figures sw = new star_wars_figures("Luke", "falcon");
            star_wars_figures sw1 = new star_wars_figures("Han Solo", "Falcon");
            star_wars_figures sw2 = new star_wars_figures("Leia", "Tie Fighter");

        }
    }
}
