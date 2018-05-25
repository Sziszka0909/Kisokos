using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ThirdWcfService
{
    //This interface contains the methods, that I will be implements in MyService.
   [ServiceContract]
    public interface IMyService
    {

        [OperationContract]
        bool Login(string username, string password);

        [OperationContract]
        void Logout(string username);

        [OperationContract]
        string addContact(string username, string phonenumber);

        [OperationContract]
        string deleteContact(string username);

        [OperationContract]
        Dictionary<string,string> showContact();

    }
}
