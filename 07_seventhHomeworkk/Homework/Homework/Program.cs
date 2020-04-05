using System;


namespace Homework
{
    //    Task 1

    //Create a class "PhotoAlbum" with a private attribute "numberOfPages".

    //It should also have a public method "GetNumberOfPages", which will return the number of pages.

    //The default constructor will create an album with 16 pages.There will be an additional constructor,
    //with which we can specify the number of pages we want in the album.

    //Create a class "BigPhotoAlbum" whose constructor will create an album with 64 pages.

    //In main method create a "PhotoAlbum" instance with its default constructor and one with 24 pages.
    //Also create "BigPhotoAlbum" and show the number of pages that the three albums have.


    public class PhotoAlbum
    {

        //default constr

        public PhotoAlbum()
        {

        }

        public PhotoAlbum(int numberOfPages)
        {
            NumberOfPages = numberOfPages;
        }



        private int NumberOfPages = 16;
        //Method
        public void GetNumberOfPages()
        {
            Console.WriteLine($" Its album with {NumberOfPages} pages");
        }

    }


        //new class //Create a class "BigPhotoAlbum" whose constructor will create an album with 64 pages.
        public class BigPhotoAlbum
        {
            public BigPhotoAlbum()
            {
                   
            }
        public int NumberOfPages = 64;


    }


        class Program
        {
            static void Main(string[] args)
            {

                

                //Class
                Console.ForegroundColor = ConsoleColor.Yellow;
                PhotoAlbum firstPhotoAlbum = new PhotoAlbum();
                firstPhotoAlbum.GetNumberOfPages();


                Console.ForegroundColor = ConsoleColor.Red;
                int theSecond = 24;
                PhotoAlbum secondPhotoAlbum = new PhotoAlbum(theSecond);
                secondPhotoAlbum.GetNumberOfPages();


                Console.ForegroundColor = ConsoleColor.Green;
                BigPhotoAlbum bigPhotoAlbum = new BigPhotoAlbum();
                Console.WriteLine($"Its the album with {bigPhotoAlbum.NumberOfPages}");



            }



        }
    }


        
