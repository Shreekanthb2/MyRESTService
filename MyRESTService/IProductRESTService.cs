using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Collections;
using System.Text;
using System.IO;

namespace MyRESTService
{
   
    [ServiceContract(Namespace ="https://www.InsightsCreative.com/Products/")]
    public interface IProductRESTService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
                                   BodyStyle = WebMessageBodyStyle.Bare,
                                   UriTemplate = "GetProductList/{name}")]
        List<Product> GetProductList(string name);

        [OperationContract(Name = "PostSampleMethod")]
        [WebInvoke(Method = "POST",
         UriTemplate = "PostSampleMethod/New")]
        string PostSampleMethod(UserDetails userInfo);
    }
}

