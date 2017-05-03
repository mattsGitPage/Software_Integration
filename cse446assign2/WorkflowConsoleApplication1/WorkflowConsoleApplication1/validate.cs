using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace WorkflowConsoleApplication1
{
    
    public sealed class validate : CodeActivity<bool>
    {
        // Define an activity input argument of type string
        public InArgument<string> userName { get; set; }
        public InArgument<string> password { get; set; }
        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override bool Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            string name = context.GetValue(userName);
            string pass = context.GetValue(password);
            bool validate = false;


            if((name == "matt") && ( pass == "password"))
            {
                validate = true;
                
            }
            return validate;   
        }
    }
}
