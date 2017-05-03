using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    /// <summary>
    /// instructor class which has information pertaining to the teacher
    /// it uses a list to store the data from the csv file
    /// the code to store the csv file was derived from the assignment instructions
    /// </summary>
    class instructor
    {

        public string Instructor { get; set; }
        public string domain { get; set; }
        public string office { get; set; }
        public string email { get; set; }

        public static List<instructor> getall()
        {
            int count = 0;
            List<instructor> teachers = new List<instructor>();
            using (var textReader = new StreamReader(@"C:\Users\matthew dunning\Documents\Visual Studio 2015\Projects\linq\linq\App_Data\instructor.csv"))
            {
                string line = textReader.ReadLine();
                int skipCount = 0;
                while (line != null && skipCount < 1)
                {
                    line = textReader.ReadLine();
                    skipCount++;
                }



                while (line != null && count != 128)
                {
                    string[] columns = line.Split(',');

                    instructor newInsrtuct = new instructor();


                 
                    newInsrtuct.Instructor = columns[0];
                    newInsrtuct.domain = columns[1];    
                    newInsrtuct.email = columns[2];
                    newInsrtuct.office = columns[3];
                    

                    teachers.Add(newInsrtuct);
                    line = textReader.ReadLine();
                    count++;

                }

            }

            return teachers;
        }
    }
}
