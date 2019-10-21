using System;
using System.Collections.Generic;

namespace get_set_ex
{
    public class star_wars_figures
    {
        //Auto implemented property
        //public string movie { get; set; }
        private string charactor;
        private string spaceship;
        private int bounty;
        List<string> StarWarMovies = new List<string>();

        public void ListOfStarWarMovies()
        {
            StarWarMovies.Add("A New Hope");
            StarWarMovies.Add("The Empire Strikes Back");
            StarWarMovies.Add("Return Of The Jedi");

            foreach (string movie in StarWarMovies)
            {
                Console.WriteLine($"Previous movies are: {movie}");
            }
        }

        public star_wars_figures()
        {

        }

        public star_wars_figures(string charactor, string spaceship)
        {


            Random rnd = new Random();
            bounty = rnd.Next(100, 1000);
            Charactor = charactor;
            Spaceship = spaceship;
        }

        public void Rightcharacter()
        {
            if (charactor == "Han Solo" || charactor == "Leia")
            {
                
                Console.WriteLine($"CORRECT CHARACTOR!!!!{Charactor}");

            }
            else
            {
                Console.WriteLine($"INCORRECT CHARACTOR!!!!{Charactor}");
            }

        }

        public void RightSpaceCraft()
        {
            if (spaceship != "Falcon")
            {
                Console.WriteLine($"INCORRECT SPACESHIP!!!!{Spaceship} for {Charactor}");
            }
            else
            {
                Console.WriteLine($"CORRECT SPACESHIP!!!!{Spaceship} for {Charactor}");
            }
        }

        public void FilthyReach()
        {
            if (bounty > 500)
            {
                Console.WriteLine($"Filthy rich!!! {Bounty} Imperial credits for {Charactor}");
            }
            else
            {
                Console.WriteLine($"{Bounty} Imperial credits for {Charactor}");
            }

            //Bounty = bounty;
        }

        public string Charactor
        {
            get
            {

                return charactor.ToUpper();
                
            }
            set
            {
                
                charactor = value;
                Rightcharacter();
                FilthyReach();
            }
        }

        public string Spaceship
        {
            get
            {
                return spaceship;
            }
            set
            {
                spaceship = value;
                RightSpaceCraft();
            }
        }

        public int Bounty
        {

            get
            {
                
                return bounty;
            }
            set
            {
              
                bounty = value;
                
            }
        }
    }
}
