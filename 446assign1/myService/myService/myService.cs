using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace myService
{
    // this is the self hosting service and it implements the two methods
    //of secretNumber and checknumber that were provided in the assignment
    //running this program will start the self hosting service and display in
    //the command prompt that the service is running
    //once this service is running the console application and the winform application
    //can both utilize this service. this was commented out in the win form application
    //to meet the assignment specifications 
    //the third project ie this one was added in order to split the code up to make debugging easier
    // I did not specify that we couldnt split it into multiple projects in the assignment
    //!! RUN AS ADMIN FOR THIS TO WORK!!
    public class myService : ImyService
    {
        public int SecretNumber(int lower, int upper)
        {
            DateTime currentDate = DateTime.Now;
            int seed = (int)currentDate.Ticks;
            Random random = new Random(seed);
            int sNumber = random.Next(lower, upper);
            return sNumber;
        }

        public string checkNumber(int userNum, int SecretNum)
        {
            if (userNum == SecretNum)
                return "correct";
            else
                if (userNum > SecretNum)
                return "too big";
            else return "too small";
        }
    }
}
