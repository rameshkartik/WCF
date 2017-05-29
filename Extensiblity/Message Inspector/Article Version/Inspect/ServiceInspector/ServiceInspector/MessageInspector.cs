using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Configuration;
using System.IO;
using System.Xml;

namespace Rameshkartik.WCFSamples.Inspector
{
    public class MessageInspector : IDispatchMessageInspector
    {

        public object AfterReceiveRequest(ref Message request, IClientChannel channel, 
            InstanceContext instanceContext)
        {
            Console.WriteLine("Message :");
            Console.WriteLine(request);
            Console.WriteLine();
            MemoryStream MS = new MemoryStream();
            XmlWriter writr = XmlWriter.Create(MS);
            request.WriteMessage(writr);
            writr.Flush();
            MS.Position = 0;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(MS);

            MS = new MemoryStream();
            xDoc.Save(MS);
            MS.Position = 0;
            XmlReader reader = XmlReader.Create(MS);
            Message NewMsg = Message.CreateMessage(reader, int.MaxValue, request.Version);
            NewMsg.Properties.CopyProperties(request.Properties);
            request = NewMsg;
            return null;
        }

        public void BeforeSendReply(ref Message reply, object correlationState)
        {
            Console.WriteLine("BeforeSendReply");
        }
    }
}
