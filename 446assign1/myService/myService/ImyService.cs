using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace myService
{
   //interface for the myService .cs
    [ServiceContract]
    public interface ImyService
    {
        [OperationContract]
        int SecretNumber(int lower, int upper);

        [OperationContract]
        string checkNumber(int userNum, int SecretNum);
    }
}
