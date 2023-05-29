
namespace F1Telemetry.Kernel
{
    public class Enum
    {
        public enum PacketType
        {
            PacketMotionData,
            PacketSessionData,
            PacketLapData,
            PacketParticipantsData,
            PacketCarSetupData,
            PacketCarTelemetryData,
            PacketCarStatusData,
            PacketFinalClassificationData,
            PacketLobbyInfoData,
            PacketCarDamageData,
            PacketSessionHistoryData,
            PacketNotImplemented
        }

        public static PacketType PackedId2Type(int _packedId)
        {
            switch (_packedId)
            {
                case 0: return PacketType.PacketMotionData;
                case 1: return PacketType.PacketSessionData;
                case 2: return PacketType.PacketLapData;
                case 4: return PacketType.PacketParticipantsData;
                case 5: return PacketType.PacketCarSetupData;
                case 6: return PacketType.PacketCarTelemetryData;
                case 7: return PacketType.PacketCarStatusData;
                case 8: return PacketType.PacketFinalClassificationData;
                case 9: return PacketType.PacketLobbyInfoData;
                case 10: return PacketType.PacketCarDamageData;
                case 11: return PacketType.PacketSessionHistoryData;
                default: return PacketType.PacketNotImplemented;
            }
        }
    }
}
