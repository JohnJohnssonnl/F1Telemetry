using F1Telemetry.Struct;

namespace F1Telemetry.Kernel
{
    internal class ApplicationPacketProcessor_PacketCarDamageData : ApplicationPacketProcessor
    {
        public override Enum.PacketType PacketType()
        {
            return Enum.PacketType.PacketCarDamageData;
        }

        public override void Run(dynamic _data)
        {
            Appl.ApplicationData.PacketCarDamageData.Add(UDPHelper.ByteArrayToPacketHeader(_data, typeof(PacketCarDamageData)));
        }
    }
}
