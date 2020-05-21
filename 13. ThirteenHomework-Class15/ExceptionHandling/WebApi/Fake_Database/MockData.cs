using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Models;

namespace WebApi.Fake_Database
{
    internal static class MockData
    {
        internal static List<User> GetMockedUsers()
        {
            User john = new User()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };
            User bob = new User()
            {
                Id = 2,
                FirstName = "Bob",
                LastName = "Bobsky"
            };
            User mark = new User()
            {
                Id = 3,
                FirstName = "Mark",
                LastName = "Dean",
                Friends = new List<User>() { john, bob }
            };
            User harry = new User()
            {
                Id = 4,
                FirstName = "Harry",
                LastName = "O'Connel",
                Friends = new List<User>() { mark }
            };
            User jina = new User()
            {
                Id = 5,
                FirstName = "Jina",
                LastName = "Johnson",
                Friends = new List<User>() { harry, bob, john }
            };
            return new List<User>() { john, bob, harry, mark, jina };
        }
        internal static List<Admin> GetAdmins ()
        {
            Admin angel = new Admin()
            {
                Id = 1,
                FirstName = "Angel",
                LastName = "Gr",
                
             
            };
            Admin miki = new Admin()
            {
                Id = 2,
                FirstName = "Miki",
                LastName = "Bobsky"
            };
            Admin marko = new Admin()
            {
                Id = 3,
                FirstName = "Marko",
                LastName = "Dean",
                Friends = new List<Admin>() { miki, angel }

            };
            Admin aca = new Admin()
            {
                Id = 4,
                FirstName = "Aca",
                LastName = "O'Connel",
               
            };
            Admin jina = new Admin()
            {
                Id = 5,
                FirstName = "Jina",
                LastName = "Johnson",
              
            };
            return new List<Admin>() { angel,miki,marko,aca,jina };
        }


    }
}
