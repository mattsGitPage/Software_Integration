using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    //This program uses RESTful service to implement the function
    //i edited the web.config file to remove the accees point as opposed
    //to using other methods, just out of personal preferance there are
    //other methods that can accomplish the same goal
    //this program implements the Number guess service as per request of the assignment
    //see the interface for the sub directories to access each method 

    //make this service run in asp.net compatibility mode 
    [AspNetCompatibilityRequirements
     (RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]

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
