using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FakeFacebook.Logger
{

    public class AdminExceptionLoggerr
    {
        private string FilePath { get; set; } = @"D:\C# CLASSES\15.Class15Prep\ExceptionHandling\ExceptionLogger.txt";
        public void AdminLogExeption(Exception ex)
        {
            StreamWriter swAdmin = new StreamWriter(FilePath);
            swAdmin.WriteLine($"{ex.GetType().Name}  {ex.Message}  {ex.StackTrace}");
            swAdmin.Close();
        }


    }

}
