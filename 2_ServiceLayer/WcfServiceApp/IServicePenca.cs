﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicePenca" in both code and config file together.
    [ServiceContract]
    public interface IServicePenca
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml,
                  BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "GetUsers/")]
        
        List<User> GetUsers();
    }
}
