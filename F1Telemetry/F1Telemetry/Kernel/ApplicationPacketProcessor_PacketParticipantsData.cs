using F1Telemetry.Struct;

namespace F1Telemetry.Kernel
{
    internal class ApplicationPacketProcessor_PacketParticipantsData : ApplicationPacketProcessor
    {
        public override Enum.PacketType PacketType()
        {
            return Enum.PacketType.PacketParticipantsData;
        }

        public override void Run(dynamic _data)
        {
            Appl.ApplicationData.PacketParticipantsData.Add(UDPHelper.ByteArrayToPacketHeader(_data, typeof(PacketParticipantsData)));
        }
    }
}
