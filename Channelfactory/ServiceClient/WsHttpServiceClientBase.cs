using System;
using System.ServiceModel;
using System.Xml.Serialization;
using Core;

namespace ServiceClient
{
    [Serializable]
    public abstract class WsHttpServiceClientBase : IWshttpServiceClient
    {
        [XmlIgnore] private readonly string _servicePath;

        private static Version _currentServiceVersion = null;

        [XmlIgnore]
        public WSHttpBinding Binding { get; protected set; }

        [XmlIgnore]
        public EndpointAddress Endpoint { get; protected set; }

        
        [XmlIgnore]
        public string ServicePath
        {
            get { return _servicePath; }
        }

        protected WsHttpServiceClientBase(WSHttpBinding binding, string servicePath)
        {
            _servicePath = servicePath;
            Binding = binding;
           
            Endpoint = MakeEndpointAddress(servicePath);

        }

        protected WsHttpServiceClientBase(string servicePath)
        {
            _servicePath = servicePath;
           
                Binding = DefaultBinding();
           
            Endpoint = MakeEndpointAddress(servicePath);
        }

        private EndpointAddress MakeEndpointAddress(string servicePath)
        {
            var uri = "http://localhost:52580/";
            if (!uri.EndsWith("/"))
                uri += "/";
            var svcPath = servicePath;
            while (svcPath.StartsWith("/"))
                svcPath = svcPath.Substring(1);
            uri += svcPath;
            return new EndpointAddress(uri);
        }

        private static WSHttpBinding DefaultBinding()
        {
            var b = new WSHttpBinding();
            b.Security.Mode = SecurityMode.None;
            b.MaxBufferPoolSize = 1524288;
            b.MaxReceivedMessageSize = 30971520;
            //b.ReaderQuotas.MaxStringContentLength = 128768;
            return b;
        }

        public abstract void Close();
        public abstract void Open();
    }
}
