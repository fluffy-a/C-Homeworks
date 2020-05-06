using LINQApp.Entities;
using LINQApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQApp
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Movie> movies = MoviesHelper.GetComedyMovies();


            //Bonus--(SQL Query syntax и Lambda syntax).

                    // 1- Find all movies that their titles starts with "L"
                             //The basic one like we did it before-
                        foreach (var movie in movies)
                        {
                            if (movie.Title.StartsWith('L'))
                            {
                                  Console.WriteLine(movie.Title);
                            }
                        }
                    //with Lamda
                    var movieFirstLetterL = movies.
                                                Where(movie => movie.Title.StartsWith('L')).ToList();
                  
                        foreach (var movie in movieFirstLetterL)
                        {
                            Console.WriteLine(movie.Title);
                        }

                    //with Query
                    var movieFirstLetterLQuery = (from movie in movies
                                                  where movie.Title.StartsWith('L')
                                                  select movie.Title).ToList();


                    //* 2- Find the NUMBER of movies that have rating higher than 7.5
                            //with lamda
                    var movieRatingLamda = movies.
                                             Count(movie => movie.Rating > 7.5);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(movieRatingLamda);



                //* 3- Find all movies TITLES with year of production before 2005
                        //with lamda
                    var movieProductionLamda = movies.
                                                Where(movie => movie.Year <= 2005).ToList();

                    Console.ForegroundColor = ConsoleColor.Red;
                    foreach (var movie in movieProductionLamda)
                    {
                        Console.WriteLine(movie.Title);
                    }
                    //with query
                    var movieProductionQuery = (from movie in movies
                                                where movie.Year <= 2005
                                                select movie.Title);

                //* 4-Find all movies TITLES and RATING that have rating higher then 8.0
                       //with lamda
                    var movieTitleRating = movies
                                     .Where(movie => movie.Rating > 8.0)
                                     .Select(movie => movie.Title)
                                     .ToList();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    foreach (var movie in movieTitleRating)
                            {
                               Console.WriteLine(movie);
                            }
                    //with query
                var movieTitleRatingQuery = (from movie in movies
                                             where movie.Rating > 8.0
                                             select movie.Title).ToList();


                    //*5- Find first 5 movies that have duration time longer then 2 hours
                    //lamda    
                    var movieLongerTwoHoursLamda = movies
                                                     .Where(movie => movie.Duration > 120)
                                                     .Take(5).ToList();
                    Console.ForegroundColor = ConsoleColor.White;
                    movieLongerTwoHoursLamda.ForEach(movie => Console.WriteLine(movie.Title));


                    //query
                    var movieLongerTwoHours = (from movie in movies
                                               where movie.Duration > 120
                                               select movie.Title).Take(5).ToList();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    movieLongerTwoHours.ForEach(movie => Console.WriteLine(movie));


                    //*6- Find last 3 movies TITLES and DURATION that have duration less then 2 hours
                    //lamda
                    var movieDruationLess = movies
                                                .Where(movie => movie.Duration < 120)
                                                .Select(movie => movie.Title).TakeLast(3).ToList();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    movieDruationLess.ForEach(movie => Console.WriteLine(movie));

                    //query
                    var movieDurationLessQuery = (from movie in movies
                                                  where movie.Duration < 120
                                                  select movie.Title).TakeLast(3).ToList();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    movieDurationLessQuery.ForEach(movie => Console.WriteLine(movie));


                    //*7- Find all movies TITLES and RATING and order them by DURATION(DESC) -no condition needed
                    //lamda
                    var RatingTitle = movies
                                       .OrderByDescending(duration => duration.Duration)
                                       .Select(movie => new { movie.Title, movie.Rating })
                                       .ToList();
                    Console.ForegroundColor = ConsoleColor.Green;
                    RatingTitle.ForEach(movie => Console.WriteLine(movie));

                    //query
                    var RatingTitleQuery = (from movie in movies
                                            orderby movie.Duration descending
                                            select movie)
                                         .Select(movie => new { movie.Title, movie.Rating }).ToList();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    RatingTitle.ForEach(movie => Console.WriteLine(movie));



                    // 8-*Find all movies with TITLES that don't start with A and TITLES include more than 7 characters
                    //lamda
                    var titleA = movies
                            .Where(movie => movie.Title.Length > 7 &&
                            !movie.Title.StartsWith('A')).ToList();

                    Console.ForegroundColor = ConsoleColor.Red;
                    titleA.ForEach(movie => Console.WriteLine(movie.Title));
                    //query
                    var titleQuery = (from movie in movies
                                      where movie.Title.Length > 7 && !movie.Title.StartsWith('A')
                                      select movie).ToList();

                    //* 9-Find all movies RATINGS that have RATINGS higher than 7.2, DURATIONS less then 1hour
                    //  and 50min
                    var RatingMoviesHigher = movies
                                                .Where(movie => movie.Rating > 7.2)
                                                .Where(movie => movie.Duration < 110)
                                                .ToList();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    RatingMoviesHigher.ForEach(movie => Console.WriteLine(movie.Rating));


                    //10- *Find all movies TITLES and RATINGS that have TITLES with less than 10 characters, DURATION
                    //  longer than 2 hours, RATING higher then 6.7 and order them by TITLE(ASC)
            
                    //lamda
                    var TitleRatingChar = movies
                                            .Where(movie => movie.Title.Length < 10)
                                            .Where(movie => movie.Duration > 120)
                                            .Where(movie => movie.Rating > 6.7)
                                            .Select(movie => movie.Title)
                                            .OrderBy(title => title)
                                            .ToList();
                    Console.ForegroundColor = ConsoleColor.Green;
                    TitleRatingChar.ForEach(movie => Console.WriteLine(movie));
                    //query

                    var titleRating = (from movie in movies
                                       where movie.Rating > 7.2f && movie.Duration > 110
                                       select movie.Rating).ToList();


                    Console.ReadLine();
                }
            }

        }