using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        //Create a new MyService instance.
        //Create a ServiceHost instance and gets the MyService instance for argument.
        //Open the host, the server is waiting the requests.
        static void Main(string[] args)
        {
            ThirdWcfService.MyService service = new ThirdWcfService.MyService();
            ServiceHost host = new ServiceHost(service);
            host.Open();
            Console.WriteLine("The server is running...");
            Console.Read();
        }
    }
}
