using System.Net;
using System.Net.Sockets;

namespace F1Telemetry.Kernel
{
    public class UDPClient
    {
        public int listenPort { get; set; }
        public UdpClient Listener { get; set; }

        private readonly Application application;

        public UDPClient(int _listenerPort, Application _application)
        {
            listenPort = _listenerPort;
            application = _application;
        }

        public void StartListening()
        {
            Listener = new UdpClient(listenPort);

            Task.Factory.StartNew(() => ListenAsync());
        }

        public Task ListenAsync()
        {
            IPEndPoint groupEP = new(IPAddress.Any, listenPort);

            try
            {
                while (true)
                {
                    byte[] bytes = Listener.Receive(ref groupEP);
                    application.NewMessageReceived(bytes);
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Listener.Close();
            }

            return Task.CompletedTask;
        }
    }
}
