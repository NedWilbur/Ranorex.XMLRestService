using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Xml.Linq;

namespace Ranorex.XMLRestService
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/{nodename}")]
        List<XElement> GetNodeData(string nodeName);
    }
}