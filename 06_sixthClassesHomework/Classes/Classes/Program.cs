using System;

namespace Classes
{
    //public class Dog


    //            Task 7
    //Create a class Dog
    //Add properties: Name, race, color
    //The dog needs to have:
    //Eat method that returns message: The dog is now eating
    //Play method returning a message : The dog is now playing
    //ChaseTail method that returns a message: Dog is now chasing its tail.
    //The user needs to create the dog object by inputs and then given an option to choose one of the actions mentioned above.



    //{


        //// Properties 
        //public string Name;
        //public string Race;
        //public string Color;

        ////Method
        //public void Eat()
        //{
        //    Console.WriteLine("The dog is now eating");

        //}
        //public void Play()
        //{
        //    Console.WriteLine("The dog is now playing");
        //}

        //public void ChaseTail()
        //{
        //    Console.WriteLine("Dog is now chasing its tail.");
        //}




        //    Create a class Human
        //Add properties: FirstName, LastName, Age
        //Create a method called GetPersonStats that returns the full name of the human as well as their age
        //Create an object human by asking the user to fill the required information
        //Call the GetPersonStats method and print the result in the console after the object is created

            public class Human
        {


            
            //Properties
            public string FirstName;
            public string LastName;
            //private string Age;



            //Method
            public void GetPersonStats()
            {
                Console.WriteLine($" Hi, I am {FirstName} {LastName} , nice to meet u");
                //HowOld(DateTime.Today);
            }
            //private void HowOld(DateTime today)
            //{
            //    if (today.Month < DateOfBirth.Month)
            //        Age = today.Year - DateOfBirth.Year - 1;
            //}


        }


        class Program
        {
            static void Main(string[] args)
            {
                //Dog dog = new Dog();

                //Console.WriteLine("Enter name for a dog");
                //dog.Name = Console.ReadLine();

                //Console.WriteLine("Enter race for a dog");
                //dog.Race = Console.ReadLine();


                //Console.WriteLine("Enter color for a dog");
                //dog.Color = Console.ReadLine();

                //while (true)
                //{
                //    Console.WriteLine("Does dog is eating? y/n");
                //    string answer = Console.ReadLine();
                //    if (answer == "y")
                //    {
                //        dog.Eat();
                //        break;
                //    }

                //    Console.WriteLine("Does dog is playing now? y/n ");

                //    string answer1 = Console.ReadLine();
                //    if (answer1 == "y")
                //    {
                //        dog.Play();
                //        break;
                //    }

                //    Console.WriteLine("Does dog chasing his tail? y/n");
                //    string answer3 = Console.ReadLine();
                //    if (answer3 == "y")
                //    {
                //        dog.ChaseTail();
                //        break;
                //    }
                //}


                //Create an object human by asking the user to fill the required information
                //class
                Human human = new Human();

                Console.WriteLine("Tell me your name");
                human.FirstName = Console.ReadLine();

                Console.WriteLine("Tell me your last name");
                human.LastName = Console.ReadLine();

                //Console.WriteLine("Tell me your age");
                //human.Age = Console.ReadLine(); private


                //Call the GetPersonStats method and print the result in the console after the object is created

                human.GetPersonStats();




                
            //}
        }
    }
    
}
