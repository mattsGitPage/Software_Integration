using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace linq
{

    class Program
    {
        static void Main(string[] args)
        {

           
            //number 2a
            // get the list information that was read in from the excel fil
            // then iterate through the coursecode to get the class and the class
            //number if it meets the specified requirements print it to the screen

            //get the info from the list and sort it first by name
            Console.WriteLine("only showing classes over 300 and sorted by teacher names in ascending order");
            
            //get all course info required which is code and instructor name then order it by the instructor name
            //list works the same better efficiency commented it out for assignment
           // var sub = course.getall().Select(s => new {  Coursecode = s.CourseCode, Instructor = s.Instructor }).OrderBy(s => s.Instructor);
              var sub = courseArray.getall().Select(s => new { Coursecode = s.CourseCode, Instructor = s.Instructor }).OrderBy(s => s.Instructor);

            IEnumerable<string> sor = courseArray.getall().Select(s1 => s1.CourseCode);
            IEnumerable<string> ar = courseArray.getall().Select(s2 => s2.Instructor);
           
            

            foreach (var subs in sub)
            {
                var courseN = subs.Coursecode;
                string s = courseN.ToString();

                //error check
                if (s.Length > 0)
                {
                    //get the first string to see if its an iee course
                    string courseS = s.Substring(0, s.IndexOf(" "));

                    if (courseS == "IEE")
                    {
                        //get the next string to verify that its over 300
                        int num = Convert.ToInt32(s.Substring(s.IndexOf(" ") + 1));

                        if (num >= 300)
                        {        //write the course and teachers name to the screen
                                Console.WriteLine(subs);
                        }
                    }
                }
            }
            Console.WriteLine("classes have been displayed press any key to move to part 2b");
            Console.ReadKey();
     
            //end of 2a


            //2b
            Console.WriteLine("grouping the course based on their tag and class number");

            //get all the courses information
            //again list works the same just more efficient
           // List<course> courses = course.getall();
            courseArray[] courses = courseArray.getall();

            //order them if they have duplicates or not
            var query =
                from course in courses
                group course by course.CourseCode into newGroup
                orderby newGroup.Key
                select newGroup;

            //use two for loops just incase the order were not 
            // automatically set in the csv file
            foreach (var nameGroup in query)
            {
                Console.WriteLine("key {0}", nameGroup.Key);

                foreach (var course in nameGroup)
                {
                    Console.WriteLine("\t{0} ", course.CourseCode);
                }
             }
            Console.WriteLine("grouping finished press any key to move to number 3");
            Console.ReadKey();



            //3 
            //write the instructors along with their email addresses and 
            //office hours to a csv file.
            //the original courses doc has been updated to include their email
            //as well as their office office could be made up as well as the email
            // so the office was randomly generated, assuming that the same teacher may have multiple offices 
            //and others may share an office just like asu

            Console.WriteLine("creating an excel sheet for the instructors");

            //using list works the same different in efficiency though
            //var rep = courseList.getall().Select(s => new {  Instructor = s.Instructor , email = s.email , office = s.office });
            var rep = courseArray.getall().Select(s => new { Instructor = s.Instructor, email = s.email, office = s.office });

            StringBuilder csv = new StringBuilder();

            //show what the top of the doc will contain and specify where to store the file
            csv.AppendLine("name, email, office");
            string path = "C:\\Users\\matthew dunning\\Documents\\Visual Studio 2015\\Projects\\linq\\linq\\App_Data\\instructor.csv";
            
            foreach (var instructor in rep)
            {
                var teacher = instructor.Instructor;
                var email = instructor.email;
                var office = instructor.office;

                var line = string.Format("{0},{1},{2}", teacher, email, office);
                csv.AppendLine(line);
             }

            //write the final contents to the file that is used for the next two problems
            //this is commented out so I dont write to your computer or create an expection with path location instead the file will
            //be saved in the project itself
            // File.WriteAllText(path, csv.ToString());

            Console.WriteLine("instructors with their office and email addresses have been written to a csv file");
            Console.ReadKey();

            //4 is stored in app_data

            //5
            //this takes the course code and teachers names from the courses file
            //and compares them with the teachers names in the instructor file
            // it them compares to see if the course code is any level of a CSE 200 course
            //if it is it prints them to the screen
            Console.WriteLine("finding courses and their instructors email address sorted by the course code");

            //get the course code and instructor name from the course file and sort them based on the course code
            // var courseCollect = courseList.getall().Select(s => new { Coursecode = s.CourseCode, Instructor = s.Instructor }).OrderBy(s => s.Coursecode);

            // list is more efficient but using the comparision of the array and the list as specified by the assignment
            var courseCollect = courseList.getall().Select(s => new { Coursecode = s.CourseCode, Instructor = s.Instructor }).OrderBy(s => s.Coursecode);
            //get the instructor name and email from the instructor class for comparision
            var emailCollect = instructor.getall().Select(s => new { tEmail = s.email, tInstructor = s.Instructor });

            foreach (var subs in courseCollect)
            {
                //error check
                if (subs.Coursecode.Length > 0 && subs.Instructor.Length > 0)
                {
                    string teachName = subs.Instructor;
                    string courseCode = subs.Coursecode;

                    foreach (var i in emailCollect)
                    {

                        string instructEmail = i.tEmail;
                        string instructTeach = i.tInstructor;

                        //split up the course code for comparision
                        string token1 = courseCode.Substring(0, courseCode.IndexOf(" "));
                        string token2 = courseCode.Substring(courseCode.IndexOf(" ") + 1);

                        //check if all the assignment requirements are met
                        if ((teachName == instructTeach) && (token1 == "CSE") && (token2 == "205" || token2 == "220" || token2 == "230" || token2 == "240" || token2 == "294"))
                        {
                            Console.WriteLine("the teachers email is {0} for course {1}", instructEmail, courseCode);
                        }

                    }
                }
            }
            Console.WriteLine("all CSE 200 level course with their teachers emails have been displayed press any button to terminate");
            Console.ReadKey();

        }
    }
}
