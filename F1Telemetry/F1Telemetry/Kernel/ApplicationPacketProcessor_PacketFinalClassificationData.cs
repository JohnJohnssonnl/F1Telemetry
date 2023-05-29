using F1Telemetry.Struct;

namespace F1Telemetry.Kernel
{
    internal class ApplicationPacketProcessor_PacketFinalClassificationData : ApplicationPacketProcessor
    {
        public override Enum.PacketType PacketType()
        {
            return Enum.PacketType.PacketFinalClassificationData;
        }
        public override void Run(dynamic _data)
        {
            Appl.ApplicationData.PacketFinalClassificationData.Add(UDPHelper.ByteArrayToPacketHeader(_data, typeof(PacketFinalClassificationData)));
        }
    }
}
