﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkflowConsoleApplication1.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService123")]
    public interface IService123 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService123/addToAccount", ReplyAction="http://tempuri.org/IService123/addToAccountResponse")]
        WorkflowConsoleApplication1.ServiceReference2.addToAccountResponse addToAccount(WorkflowConsoleApplication1.ServiceReference2.addToAccountRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService123/addToAccount", ReplyAction="http://tempuri.org/IService123/addToAccountResponse")]
        System.Threading.Tasks.Task<WorkflowConsoleApplication1.ServiceReference2.addToAccountResponse> addToAccountAsync(WorkflowConsoleApplication1.ServiceReference2.addToAccountRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="addToAccount", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class addToAccountRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int value;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int added;
        
        public addToAccountRequest() {
        }
        
        public addToAccountRequest(int value, int added) {
            this.value = value;
            this.added = added;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="addToAccountResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class addToAccountResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int addToAccountResult;
        
        public addToAccountResponse() {
        }
        
        public addToAccountResponse(int addToAccountResult) {
            this.addToAccountResult = addToAccountResult;
        }
    }
}
