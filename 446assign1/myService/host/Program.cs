using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace host
{
    class Program
    {
        //!!-- IMPORTANT this solutin needs to be ran in administrator mode to open the host !!
        //the service and the hosting code was generated in the App.config file
        //they are located in host and the instance is created here in main
        // all other clients will communicate via this self host when it is open
        
        static void Main(string[] args)
        {
            //define the service host that will be used to open the self hosting service
            using (ServiceHost host = new ServiceHost(typeof(myService.myService))) 
            {
                //this opens to host service and it will not be killed until the user terminates it
                host.Open();
                Console.WriteLine("host started");
                Console.ReadLine();
            }
        }
    }
}
