using LINQApp.Entities;
using System;
using System.Collections.Generic;

namespace LINQApp.Helpers
{
    public class MoviesHelper
    {
        public static List<Movie> GetComedyMovies()
        {
            return new List<Movie>()
            {


                new Movie(){ Title = "The Mountain II", Year = 2016, Rating = 8.9f, Duration = 135 },
                new Movie(){ Title = "Seven Samurai", Year = 1954, Rating = 8.6f, Duration = 207 },
                new Movie(){ Title = "Big Hero 6", Year = 2014, Rating = 7.8f, Duration = 102 },
                new Movie(){ Title = "The Man from Nowhere", Year = 2010, Rating = 7.8f, Duration = 119 },
                new Movie(){ Title = "Gladiator", Year = 2000, Rating = 8.5f, Duration = 155 },
                new Movie(){ Title = "Avengers: Endgame", Year = 2009, Rating = 8.4f, Duration = 181 },
                new Movie(){ Title = "Kung Fu Hustle", Year = 2004, Rating = 7.7f, Duration = 99 },
                new Movie(){ Title = "Iron Man", Year = 2008, Rating = 7.9f, Duration = 126 },
                new Movie(){ Title = "Big Hero 7", Year = 2014, Rating = 7.8f, Duration = 102 },
                new Movie(){ Title = "The Dark Knight", Year = 2008, Rating = 9.0f, Duration = 152 },
                new Movie(){ Title = "13 Assassins", Year = 2010, Rating = 7.6f, Duration = 141 },
                new Movie(){ Title = "Grindhouse", Year = 2007, Rating = 7.5f, Duration = 191 },


                new Movie() {Title= "Just Go with It", Year=2011,Rating=6.4f, Duration=120 },
                new Movie() {Title= "Late Night", Year=2019, Rating = 7.8f, Duration = 102 },
                new Movie() {Title="What Men Want", Year= 2000, Rating = 8.5f, Duration = 155},
                new Movie(){ Title = "Mean Girls", Year = 2010, Rating = 7.6f, Duration = 141 },
                new Movie(){ Title = "Clueless", Year = 1954, Rating = 8.6f, Duration = 207 },
                new Movie(){ Title = "The Other Woman", Year = 2014, Rating = 7.8f, Duration = 102 },
                new Movie(){ Title = "The Duff", Year = 2015, Rating = 5.8f, Duration = 108 },
                new Movie() {Title="The wedding planner", Year= 2005, Rating = 7.5f, Duration = 120},
                new Movie() {Title= "She's the Man ", Year=2016, Rating = 6.3f, Duration = 102 },
                new Movie() {Title= "The Ugly Truth", Year=2009, Rating = 6.4f, Duration = 132 },

                 

            };

        }

                   

    }

}