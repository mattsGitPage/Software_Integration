using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class courseArray
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



        public static courseArray[] getall()
        {
            int count = 0;
            courseArray[] prac1 = new courseArray[128];
            using (var textReader = new StreamReader(@"C:\Users\matthew dunning\Documents\Visual Studio 2015\Projects\linq\linq\App_Data\coursesss.csv"))
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

                    prac1[count] = new courseArray();


                    prac1[count].CourseId = columns[0];
                    prac1[count].CourseCode = columns[1];
                    prac1[count].Title = columns[2];
                    prac1[count].Units = columns[3];
                    prac1[count].Dates = columns[4];
                    prac1[count].Days = columns[5];
                    prac1[count].Start = columns[6];
                    prac1[count].End = columns[7];
                    prac1[count].Location = columns[8];
                    prac1[count].GS = columns[9];
                    prac1[count].Instructor = columns[10];
                    prac1[count].domain = columns[11];
                    prac1[count].office = columns[12];
                    prac1[count].email = columns[13];

                    
                    line = textReader.ReadLine();
                    count++;

                }

            }

            return prac1;
        }
    }
}
