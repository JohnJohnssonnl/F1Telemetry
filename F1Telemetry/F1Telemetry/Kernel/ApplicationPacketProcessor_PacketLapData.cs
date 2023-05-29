using F1Telemetry.Struct;

namespace F1Telemetry.Kernel
{
    internal class ApplicationPacketProcessor_PacketLapData : ApplicationPacketProcessor
    {
        public override Enum.PacketType PacketType()
        {
            return Enum.PacketType.PacketLapData;
        }

        public override void Run(dynamic _data)
        {
            Appl.ApplicationData.PacketLapData.Add(UDPHelper.ByteArrayToPacketHeader(_data, typeof(PacketLapData)));
        }
    }
}
