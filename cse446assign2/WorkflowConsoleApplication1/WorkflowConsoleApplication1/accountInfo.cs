using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace WorkflowConsoleApplication1
{

    public sealed class accountInfo : CodeActivity<int>
    {
       
        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override int Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            Random accountBalance = new Random();
            int ammount = accountBalance.Next(1000, 5000);

            return ammount;
        }
    }
}
