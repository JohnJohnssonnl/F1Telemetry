using F1Telemetry.Kernel;
using F1Telemetry.Struct;

namespace F1Telemetry
{
    public class Application
    {
        public ApplicationData ApplicationData { get; set; }
        private UDPClient udpClient { get; set; }
        public dynamic externalApplication;

        public Application(int _port, dynamic _externalApplication)
        {
            externalApplication = _externalApplication;
            ApplicationData = new ApplicationData();
            udpClient = new UDPClient(_port, this);
            udpClient.StartListening();
            Console.Write("Application has started");
        }

        public void NewMessageReceived(byte[] _packet)
        {
            PacketHeader packetHeader = (PacketHeader)UDPHelper.ByteArrayToPacketHeader(_packet, typeof(PacketHeader));

            //Add the received packet to the library
            Kernel.Enum.PacketType packettype = Kernel.Enum.PackedId2Type(packetHeader.m_packetId);
            ApplicationPacketProcessor packetProcessor = ApplicationPacketProcessor.Construct(packettype, this);
            packetProcessor.Run(_packet);
            externalApplication.NewMessageReceived();
        }
    }
}
