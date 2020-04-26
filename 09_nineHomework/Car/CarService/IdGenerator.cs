using System;
using System.Security.Cryptography;

namespace CarService
{
    public class IdGenerator
    {

        public static int GenerateID()
        {
            Random rand = new Random();
            int IdCode = rand.Next(1, 20);
            return IdCode;
        }


    }
}
