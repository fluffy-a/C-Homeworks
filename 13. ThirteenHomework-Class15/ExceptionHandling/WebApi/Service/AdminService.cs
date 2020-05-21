using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.Exceptions;
using WebApi.Fake_Database;
using WebApi.Models;

namespace WebApi.Service
{
   public static class AdminService
    {
        public static List<Admin> GetAdmins()
        {
            return DB.Admins;
        }
        public static Admin GetAdmin(int id)
        {
            Admin admin = DB.Admins.Single(admin => admin.Id == id);
            return admin;
        }

       public static List<Admin>GetAllAdminFriends(Admin findadmin)
        {
            if (findadmin == null)
            {
                throw new AdminServiceException("You send me a null", new Exception());
            }
            var allAdminFriends = DB.Admins.Single(admin => admin.Equals(findadmin));
            return allAdminFriends.Friends;


        }


    }
}
