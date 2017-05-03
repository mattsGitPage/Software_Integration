using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
   
    /// <summary>
    /// defines a course class that has all sorts of variables that
    /// describe the characteristics of the asu class
    /// the class reads a csv file and stores it into a corresponding data structure
    /// so we can access all the values later
    /// the code for reading of the csv file was obtained from the assignment instructions
    /// !!!! office domanin and email were added to link this to the instructor file to read it
    /// i did not use this as the source for the last two problems simply as a way to transfer emails and office to other file
    /// as i could not find a way to send excel formulas and get them to execute in a specific row!!!!!!!!
    /// </summary>
        public class courseList
        {
            public string CourseId { get; set; }
            public string CourseCode { get; set; }
            public string Title { get; set; }
            public string Location { get; set; }
            public string Instructor { get; set; }
            public string Units { get; set; }
            public string Dates { get; set; }
            public string Days { get; set; }
            public string Start { get; set; }
            public string End { get; set; }
            public string GS { get; set; }
            public string domain { get; set; }
            public string office { get; set; }
            public string email { get; set; }
         


            public static List<courseList> getall()
            {
            int count = 0;
            List<courseList> courses = new List<courseList>();
                using (var textReader = new StreamReader(@"C:\Users\matthew dunning\Documents\Visual Studio 2015\Projects\linq\linq\App_Data\coursesss.csv"))
                {
                    string line = textReader.ReadLine();
                    int skipCount = 0;
                    while (line != null && skipCount < 1)
                    {
                        line = textReader.ReadLine();
                        skipCount++;
                    }



                while(line!=null && count != 128)
                { 
                    string[] columns = line.Split(',');

                    courseList newC = new courseList();


                    newC.CourseId = columns[0];
                            newC.CourseCode = columns[1];
                            newC.Title = columns[2];
                            newC.Units = columns[3];
                            newC.Dates = columns[4];
                            newC.Days = columns[5];
                            newC.Start = columns[6];
                            newC.End = columns[7];
                            newC.Location = columns[8];
                            newC.GS = columns[9];
                            newC.Instructor = columns[10];
                    newC.domain = columns[11];
                    newC.office = columns[12];
                    newC.email = columns[13];

                    courses.Add(newC);
                    line = textReader.ReadLine();
                    count++;
                    
                }

                }

                return courses;
            }
        }
    }

