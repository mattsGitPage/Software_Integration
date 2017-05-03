using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace numWCF
{
    // interface for the guessing game
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        int SecretNumber(int lower, int upper);

        [OperationContract]
        string checkNumber(int userNum, int SecretNum);
        
    }
   
}
