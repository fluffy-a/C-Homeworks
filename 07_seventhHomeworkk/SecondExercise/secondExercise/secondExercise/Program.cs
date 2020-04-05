using System;

namespace secondExercise
{

    //    Task 2
    ////In this exercise you are asked to program three simple classes which keep track of the grading of a sample student.
    //    The classes are called FirstCourse, SecondCourse, and Project.
    ////A FirstCourse encapsulates a course name and a registration of passed/not passed for our sample student.
    ////A SecondCourse encapsulates a course name and the grade of the student. For grading we use the grades, 
    //numerical grades 10, 9, 8, 7, 6, 5. You are also welcome use the enumeration.The grade 6 is the lowest passing grade.
    ////In both FirstCourse and SecondCourse you should write a method called Passed. 
    //The method is supposed to return whether our sample student passes the course.
    ////The class Project aggregates two FirstCourse courses and two SecondCourse courses.
    //You can assume that a project is passed if at least three out of the four courses are passed. 
    //    Write a method Passed in class Project which implements this passing policy.
    ////In Main method initialize 2 FirstCourse objects, 2 SecondCourse objects and 1 Project object.
    //Add both FirstCourse and both SecondCourse objects like a properties to Project object. 
    //            Call Project's object Passed method to see if the student passed.

    //first class with two inputs
    public class FirstCourse
    {

        public FirstCourse(string courseName, bool pass)
        {
            CourseName = courseName;
            Pass = pass;
        }

        public string CourseName;
        public bool Pass;
        public bool Passed()
        {
            if (Pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
    //second class 
    public class SecondCourse
    {
        public SecondCourse(string thisCourseName, gradeOfAStudent thisGrade)
        {
            ThisCourseName = thisCourseName;
            ThisGrade = thisGrade;

        }
        public string ThisCourseName;
        public gradeOfAStudent ThisGrade;


        public bool Passed()
        {

            if (ThisGrade != gradeOfAStudent.Grade6)
            {
                return true;
            }
            else { return false; }


        }

    }
    //enum
    public enum gradeOfAStudent
    {
        Grade1 = 10,
        Grade2 = 9,
        Grade3 = 8,
        Grade4 = 7,
        Grade5 = 6,
        Grade6 = 5
    }


    public class Project
    {
        public Project(bool courseOne, bool courseTwo, bool courseThree, bool courseFour)
        {
            CourseOne = courseOne;
            CourseTwo = courseTwo;
            CourseThree = courseThree;
            CourseFour = courseFour;
        }

        bool CourseOne;
        bool CourseTwo;
        bool CourseThree;
        bool CourseFour;
        //You can assume that a project is passed if at least three out of the four courses are passed. 
        //Write a method Passed in class Project which implements this passing policy.
        public void Passed()
        {
            bool[] array = { CourseOne, CourseTwo, CourseThree, CourseFour };
            int count = 0;

            foreach (var item in array)
            {
                count++;
            }
            if (count > 2)
            {
                Console.WriteLine($"U r passed and u have {count} courses achieved. Congrats!");

            }
            else
            {
                Console.WriteLine("U faild, try more next time");
            }
        }



    }






    class Program
    {
        static void Main(string[] args)
        {



            //Call Project's object Passed method to see if the student passed.

            var FirstCourse1 = new FirstCourse("English", true);
            var FirstCourse2 = new FirstCourse("Math", true);


            var SecondCourse3 = new SecondCourse("Economy", gradeOfAStudent.Grade1);

            var SecondCourse4 = new SecondCourse("Commerce", gradeOfAStudent.Grade4);

            Project project = new Project(FirstCourse1.Passed(), FirstCourse2.Passed(), SecondCourse3.Passed(), SecondCourse4.Passed());

            project.Passed();







            Console.ReadLine();






        }
    }
}
