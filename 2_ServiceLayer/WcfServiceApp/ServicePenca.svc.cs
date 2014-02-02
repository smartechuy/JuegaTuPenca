using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicePenca" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicePenca.svc or ServicePenca.svc.cs at the Solution Explorer and start debugging.
    public class ServicePenca : IServicePenca
    {
        public List<User> GetUsers()
        {
           List<User> users = new List<User>();
        
         users.Add(new User() { userKey = 1, Name = "Product 1", photoUrl = "/url1"});
         users.Add(new User() { userKey = 1, Name = "Product 2", photoUrl = "/url2"});
         users.Add(new User() { userKey = 1, Name = "Product 3", photoUrl = "/url3"});
         users.Add(new User() { userKey = 1, Name = "Product 4", photoUrl = "/url4" });

         return users;
        }

    }



}
