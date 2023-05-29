using F1Telemetry.Struct;
using System.Runtime.InteropServices;

namespace F1Telemetry.Kernel
{
    internal class UDPHelper
    {
        public static object? ByteArrayToPacketHeader(byte[] bytes, Type _typeToConvertTo)
        {
            GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            object? unpackedObject;
            try
            {
                unpackedObject = Marshal.PtrToStructure(handle.AddrOfPinnedObject(), _typeToConvertTo);
            }
            finally
            {
                handle.Free();
            }
            return unpackedObject;
        }
        public static Type? GetPacketId2ObjectType(int _packetId)
        {
            switch (_packetId)
            {
                case 0: return typeof(PacketMotionData);
                case 1: return typeof(PacketSessionData);
                case 2: return typeof(PacketLapData);
                //case 3: return typeof(eventdatas) //TODO: Fix
                case 4: return typeof(PacketParticipantsData);
                case 5: return typeof(PacketCarSetupData);
                case 6: return typeof(PacketCarTelemetryData);
                case 7: return typeof(PacketCarStatusData);
                case 8: return typeof(PacketFinalClassificationData);
                case 9: return typeof(PacketLobbyInfoData);
                case 10: return typeof(PacketCarDamageData);
                case 11: return typeof(PacketSessionHistoryData);
                default: return null;
            }

        }
    }
}
