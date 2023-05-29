using F1Telemetry.Struct;

namespace F1Telemetry.Kernel
{
    internal class ApplicationPacketProcessor_PacketLobbyInfoData : ApplicationPacketProcessor
    {
        public override Enum.PacketType PacketType()
        {
            return Enum.PacketType.PacketLobbyInfoData;
        }

        public override void Run(dynamic _data)
        {
            Appl.ApplicationData.PacketLobbyInfoData.Add(UDPHelper.ByteArrayToPacketHeader(_data, typeof(PacketLobbyInfoData)));
        }
    }
}
