using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace numWCF
{
    //this solution contains number one and two of the assignement
    //in order for  this to work you need to have the wcf service
    //running in the browser and then start a new instance of the 
    //windows form application
    //the numguess code was provided via the assignment
    public class Service1 : IService1
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
