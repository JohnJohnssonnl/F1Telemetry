namespace F1Telemetry.Kernel
{
    abstract class ApplicationPacketProcessor
    {
        public Application Appl;

        public static ApplicationPacketProcessor Construct(Enum.PacketType _packetType, Application _application)
        {
            ApplicationPacketProcessor ret;

            switch (_packetType)
            {
                case Enum.PacketType.PacketCarDamageData: ret = new ApplicationPacketProcessor_PacketCarDamageData(); break;
                case Enum.PacketType.PacketLapData: ret = new ApplicationPacketProcessor_PacketLapData(); break;
                case Enum.PacketType.PacketCarSetupData: ret = new ApplicationPacketProcessor_PacketCarSetupData(); break;
                case Enum.PacketType.PacketMotionData: ret = new ApplicationPacketProcessor_PacketMotionData(); break;
                case Enum.PacketType.PacketSessionData: ret = new ApplicationPacketProcessor_PacketSessionData(); break;
                case Enum.PacketType.PacketParticipantsData: ret = new ApplicationPacketProcessor_PacketParticipantsData(); break;
                case Enum.PacketType.PacketCarStatusData: ret = new ApplicationPacketProcessor_PacketCarStatusData(); break;
                case Enum.PacketType.PacketSessionHistoryData: ret = new ApplicationPacketProcessor_PacketSessionHistoryData(); break;
                case Enum.PacketType.PacketCarTelemetryData: ret = new ApplicationPacketProcessor_PacketCarTelemetryData(); break;
                case Enum.PacketType.PacketLobbyInfoData: ret = new ApplicationPacketProcessor_PacketLobbyInfoData(); break;
                case Enum.PacketType.PacketFinalClassificationData: ret = new ApplicationPacketProcessor_PacketFinalClassificationData(); break;
                default: ret = new ApplicationPacketProcessor_PacketNotImplemented(); break;
            }
            ret.Appl = _application;

            return ret;
        }

        public abstract void Run(dynamic _data);
        public abstract Enum.PacketType PacketType();
    }
}
