using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Windows;

namespace SudokyProject
{
    public class MyServiceUser
    {

        [ServiceContract]
        public interface IMyService
        {
            [OperationContract]
            int[] SendLevel(int level, string uri);

            [OperationContract]
            string SendResult(string str, string uri);

            [OperationContract]
            string SendAllResult();

        }
        public class MyService : IMyService
        {

            public int[] SendLevel(int level, string uri)
            {
                throw new NotImplementedException();
            }

            public string SendResult(string str, string uri)
            {
                throw new NotImplementedException();
            }

            public string SendAllResult()
            {
                throw new NotImplementedException();
            }
        }

        public class WorkingWithServer
        {
            private static string _uri;
            static string Uri
            {
                get
                {
                    return _uri;
                }
                set
                {
                    _uri = "http://localhost:" + value + "/MyService";
                }
            }

            public static ServiceHost CreateUserHost()
            {
                var rand = new Random();
                var port = rand.Next(8002, 8020);
                Uri = Convert.ToString(port);

                ServiceHost host = new ServiceHost(typeof(MyService), new Uri(Uri));
                host.AddServiceEndpoint(typeof(IMyService), new BasicHttpBinding(), "");
                return host;
            }

            public static int[] SendLevelFromUserToServer(int level)
            {
                Uri tcpUri = new Uri("http://localhost:8001/MyService");
                EndpointAddress address = new EndpointAddress(tcpUri);
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.ReceiveTimeout = new TimeSpan(0, 10, 0);

                int[] arr = null;

                using (ChannelFactory<IMyService> factory = new ChannelFactory<IMyService>(binding, address))
                {
                    IMyService service = factory.CreateChannel();
                    arr = service.SendLevel(level, Uri);
                }
                return arr;
            }

            public static string SendResultFromUserToServer(string mess, string time, string sqore)
            {
                Uri tcpUri = new Uri("http://localhost:8001/MyService");
                EndpointAddress address = new EndpointAddress(tcpUri);
                BasicHttpBinding binding = new BasicHttpBinding();
                string strResults;
                using (ChannelFactory<IMyService> factory = new ChannelFactory<IMyService>(binding, address))
                {
                    IMyService service = factory.CreateChannel();
                    strResults = service.SendResult(mess, time);
                }
                return strResults;
            }

            public static string SendAllResultFromUserToServer()
            {
                Uri tcpUri = new Uri("http://localhost:8001/MyService");
                EndpointAddress address = new EndpointAddress(tcpUri);
                BasicHttpBinding binding = new BasicHttpBinding();
                string strResults;
                using (ChannelFactory<IMyService> factory = new ChannelFactory<IMyService>(binding, address))
                {
                    IMyService service = factory.CreateChannel();
                    strResults = service.SendAllResult();
                }
                return strResults;
            }
        }
    }

}