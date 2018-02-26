using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace ServiceClient
{
    public class DemoServiceClient : WsHttpServiceClientBase, IDemoService
    {
        public const string DefaultServicePath = "DemoService.svc";

        public ChannelFactory<IDemoService> ChannelFactory { get; protected set; }
        private  IDemoService Channel { get; set; }

        public DemoServiceClient() : base(DefaultServicePath)
        {
            
        }
        public string Greetings()
        {
           CheckOpen();
            return Channel.Greetings();
        }

        private void CheckOpen()
        {
            if (ChannelFactory == null)
                Open();
        }

        public override void Open()
        {
            ChannelFactory = new ChannelFactory<IDemoService>(Binding, Endpoint);
            Channel = ChannelFactory.CreateChannel();
          
        }

        public override void Close()
        {
            if (ChannelFactory == null)
                return;
            Channel = null;
            ChannelFactory.Close();
            ChannelFactory = null;
        }
    }
}
