using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ranorex.XMLRestService
{
    class Service : IService
    {
        ///UriTemplate = "/{nodename}"
        public List<XElement> GetNodeData(string nodeName)
        {
            Console.WriteLine($"CALL GetNodeData({nodeName})");
            try
            {
                XDocument xdoc = XDocument.Load("SampleReport.rxlog.data");
                List<XElement> elements = xdoc.Descendants(nodeName).ToList();
                return elements;
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine(string.Empty);
            }
            return null;
        }
    }
}
