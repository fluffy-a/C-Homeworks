using System;
using System.Collections.Generic;
using System.Linq;
using TeamSource.Enteties;
using TeamSource.Helpers;

namespace GameCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            var teams = TeamsDataBase.GetAllTeams();
            foreach (var team in teams)
            {
                Console.WriteLine(team.Name);
            }
            //1-Find all Teams with names starting with LA

            var teamsStartingWithLa =
                               teams.Where(team => team.Name.StartsWith("LA")).ToList();
            //  teamsStartingWithLa.ForEach(team => Console.WriteLine(team.Name));


            //2-Find all team Names which are playint in Staples Center
            var teamsPlayingInSteplaesCenter = teams
                                        .Where(team => team.Arena == "Staples Center")
                                        //moze i team.Arena.Equals("Staples Center")
                                        .Select(team => team.Name).ToList();
            teamsPlayingInSteplaesCenter.ForEach(team => Console.WriteLine(team));

            //3-Find all teams coaches
            var allCoaches = teams.
                            Select(team => team.Coach).ToList();
            allCoaches.ForEach(coach => Console.WriteLine(coach.FullName));


            //Find 3 oldest coaches Names and age
            var oldest3CoachesNameAndAge = allCoaches.
                          OrderByDescending(coach => coach.Age)
                          .Take(3)
                          .Select(coach => coach.FullName)
                          .ToList();
            oldest3CoachesNameAndAge.ForEach(trainerName => Console.WriteLine(trainerName));

            //Group all teams by their arenas

            var groupTeams = teams.
                    GroupBy(team => team.Arena) .ToList();
            //Console.ForegroundColor = ConsoleColor.Red;
            //foreach (var group in groupTeams)
            //{
            //    Console.WriteLine($"{group.Key}");
            //    foreach (var team in group)
            //    {
            //        Console.WriteLine($"{team.Name}");
            //    }
            //}

            //Find all players
            var allPlayers = new List<Player>();
            teams.ForEach(team => allPlayers.AddRange(team.Players));
            allPlayers.ForEach(player => Console.WriteLine(player.FullName));

            //          dali xznaci deka sekogas koga ima nesto
            //          sto treba da zememe od klasa vo klasa
            //          treba da si pravime prazna lista kako sega
            //          ako sakame od lista u klasa valjda

            //Find player with best avgPointsPerGame
            var Avg = allPlayers
                .OrderByDescending(player => player.PlayerStatistic["PtsPerGame"])
                .FirstOrDefault();

            //Console.WriteLine(playerWithMostPtsPerGame.FullName);



            // HOMEWORK

            // Find all coaches NAMES with Age > 50
            var CoachesNameBiggerThanFifthy = teams.
                                             Where(team => team.Coach.Age > 50).ToList();
            Console.ForegroundColor = ConsoleColor.Blue;
            CoachesNameBiggerThanFifthy.ForEach(coach => Console.WriteLine(coach.Name));

            // Order players by AGE - DESC
            var playersByAge = allPlayers.
                           OrderByDescending(player => player.Age).ToList();
            Console.ForegroundColor = ConsoleColor.White;
            playersByAge.ForEach(player => Console.WriteLine(player.Age));

            // Find player with highest RebPerGame
            var HighestPlayer = allPlayers.
                                OrderByDescending(player => player.PlayerStatistic["RebPerGame"]).ToList();
            Console.ForegroundColor = ConsoleColor.Green;
            HighestPlayer.ForEach(player => Console.WriteLine(player.FullName));


            // Find all players with PtsPerGame > 20
            var PLayerPts = allPlayers.
                               Where(player => player.PlayerStatistic["PtsPerGame"] > 20.0f).ToList();
            Console.ForegroundColor = ConsoleColor.Yellow;
            PLayerPts.ForEach(player => Console.WriteLine(player.FullName));


            // Find all players NAMES older then 30 years
            var PlayerNameOlder = allPlayers.
                                    Where(player => player.Age > 30)
                                    .Select(player => player.FullName).ToList();
            Console.ForegroundColor = ConsoleColor.Red;
            PlayerNameOlder.ForEach(player => Console.WriteLine(player));


            // Group players by age

            var groupTeam = allPlayers.
                    GroupBy(player => player.Age).ToList();
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var group in groupTeam)
            {
                Console.WriteLine($"{group.Key }");
                foreach (var player in group)
                {
                    Console.WriteLine($"{player.FullName}");
                }
            }


            // Find All players NAMES and PtsPerGame if have RebPerGame > 7.0
            var PrsNamesPlayer = allPlayers.
                                    Where(player => player.PlayerStatistic["PtsPerGame"] > 7.0f)
                                    .Select(player => player.FullName).ToList();
            Console.ForegroundColor = ConsoleColor.Red;
            PrsNamesPlayer.ForEach(player => Console.WriteLine(player));

            // Find first 3 players with highest PtsPerGame
            var HighestPlayer1 = allPlayers.
                               OrderByDescending(player => player.PlayerStatistic["PtsPerGame"])
                               .Select(player => player.FullName).Take(3).ToList();
            Console.ForegroundColor = ConsoleColor.Green;
            HighestPlayer1.ForEach(player => Console.WriteLine(player));

            // Find the team which has the player with highest PtsPerGame
            var playerPts = allPlayers.
                           OrderByDescending(player => player.PlayerStatistic["PtsPerGame"]).FirstOrDefault();
            var BestPlayer = teams.SingleOrDefault(team => team.Players.Contains(playerPts));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(BestPlayer.Name);   //I dont have other idea

            // Find first 4 players with highest RebPerGame and order them by PtsPerGame - ASC
            var FourPlayers = allPlayers
                            .OrderBy(player => player.PlayerStatistic["RebPerGame"]) .TakeLast(4)
                            .OrderBy(player => player.PlayerStatistic["PtsPerGame"]).ToList();
            //fourPhighestRebPerGame.ForEach(player => Console.WriteLine(player.FullName));






        }

    }
}
