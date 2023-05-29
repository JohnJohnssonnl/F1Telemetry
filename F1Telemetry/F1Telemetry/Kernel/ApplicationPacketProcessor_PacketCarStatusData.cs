using F1Telemetry.Struct;

namespace F1Telemetry.Kernel
{
    internal class ApplicationPacketProcessor_PacketCarStatusData : ApplicationPacketProcessor
    {
        public override Enum.PacketType PacketType()
        {
            return Enum.PacketType.PacketCarStatusData;
        }
        public override void Run(dynamic _data)
        {
            Appl.ApplicationData.PacketCarStatusData.Add(UDPHelper.ByteArrayToPacketHeader(_data, typeof(PacketCarStatusData)));
        }
    }
}
