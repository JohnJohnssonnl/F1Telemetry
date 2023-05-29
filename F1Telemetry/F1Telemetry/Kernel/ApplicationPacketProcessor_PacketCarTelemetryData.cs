using F1Telemetry.Struct;

namespace F1Telemetry.Kernel
{
    internal class ApplicationPacketProcessor_PacketCarTelemetryData : ApplicationPacketProcessor
    {
        public override Enum.PacketType PacketType()
        {
            return Enum.PacketType.PacketCarTelemetryData;
        }

        public override void Run(dynamic _data)
        {
            Appl.ApplicationData.PacketCarTelemetryData.Add(UDPHelper.ByteArrayToPacketHeader(_data, typeof(PacketCarTelemetryData)));
        }
    }
}
