using FakeFacebook.Logger;
using System;
using WebApi.Exceptions;
using WebApi.Models;
using WebApi.Service;

namespace FakeFacebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var allUsers = UserService.GetAllUsers();
            //foreach (var user in allUsers)
            //{
            //    Console.WriteLine(user.FirstName);
            //}
            try
            {
                // var userByID = UserService.GetUserById(4);
                var usersFriends = UserService.GetAllUsersFriends(null);
                foreach (var user in usersFriends)
                {
                    Console.WriteLine(user.FirstName);
                }
                // Console.WriteLine(userByID.FirstName);
            }
            catch (UserServiceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                var logger = new UserExceptionsLogger();
                logger.LogException(ex);
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("I proceed to work");


            var allAdmins = AdminService.GetAdmins();
            // foreach (var admin in allAdmins)
            //{
            //   Console.WriteLine(admin.FirstName);
            //}

            try
            {
             //  var adminById = AdminService.GetAdmin(6);
                var adminFriends = AdminService.GetAllAdminFriends(null);
                
                foreach (var admin in adminFriends)
                {
                    Console.WriteLine(admin.FirstName);
                }
                // Console.WriteLine(adminById.FirstName); //Aca -  it will never happened
                //Console.WriteLine("Again i proceed  to work"); //it will never happened
            }

            catch (AdminServiceException ex)
            {
                Console.WriteLine(ex.Message);
            }


            catch (Exception ex)
            {
                var logger = new AdminExceptionLoggerr();
                logger.AdminLogExeption(ex);
                Console.WriteLine(ex.Message);//Sequence contains no matching element
                
            }
           Console.WriteLine("Again i proceed  to work"); // if its there it will happen

       











            Console.ReadLine();
        }
    }
}
