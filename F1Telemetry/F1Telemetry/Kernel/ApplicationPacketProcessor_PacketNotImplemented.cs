namespace F1Telemetry.Kernel
{
    internal class ApplicationPacketProcessor_PacketNotImplemented : ApplicationPacketProcessor
    {
        public override Enum.PacketType PacketType()
        {
            return Enum.PacketType.PacketNotImplemented;
        }

        public override void Run(dynamic _data)
        {
            //Do nothing as there isn't an implementation
        }
    }
}
