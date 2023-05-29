using F1Telemetry.Struct;

namespace F1Telemetry.Kernel
{
    internal class ApplicationPacketProcessor_PacketMotionData : ApplicationPacketProcessor
    {
        public override Enum.PacketType PacketType()
        {
            return Enum.PacketType.PacketMotionData;
        }

        public override void Run(dynamic _data)
        {
            Appl.ApplicationData.PacketMotionData.Add(UDPHelper.ByteArrayToPacketHeader(_data, typeof(PacketMotionData)));
        }
    }
}
