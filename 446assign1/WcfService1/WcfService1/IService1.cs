using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
  
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(UriTemplate = "get?lowerB={lower}&upperB={upper}")]
        int SecretNumber(int lower, int upper);

        [OperationContract]
        [WebGet(UriTemplate = "check?UserNum={userNum}&SecretNum={SecretNum}", ResponseFormat = WebMessageFormat.Json)]
        string checkNumber(int userNum, int SecretNum);
      
    }


  
}
