using F1Telemetry.Struct;

namespace F1Telemetry.Kernel
{
    internal class ApplicationPacketProcessor_PacketCarSetupData : ApplicationPacketProcessor
    {
        public override Enum.PacketType PacketType()
        {
            return Enum.PacketType.PacketCarSetupData;
        }
        public override void Run(dynamic _data)
        {
            Appl.ApplicationData.PacketCarSetupData.Add(UDPHelper.ByteArrayToPacketHeader(_data, typeof(PacketCarSetupData)));
        }
    }
}
