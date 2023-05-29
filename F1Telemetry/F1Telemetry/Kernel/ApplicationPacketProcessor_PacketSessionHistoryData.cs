using F1Telemetry.Struct;

namespace F1Telemetry.Kernel
{
    internal class ApplicationPacketProcessor_PacketSessionHistoryData : ApplicationPacketProcessor
    {
        public override Enum.PacketType PacketType()
        {
            return Enum.PacketType.PacketSessionHistoryData;
        }
        public override void Run(dynamic _data)
        {
            Appl.ApplicationData.PacketSessionHistoryData.Add(UDPHelper.ByteArrayToPacketHeader(_data, typeof(PacketSessionHistoryData)));
        }
    }
}
