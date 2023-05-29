using System.Runtime.InteropServices;

namespace F1Telemetry.Struct
{
    public struct PacketParticipantsData
    {
        sbyte m_numActiveCars; // Number of active cars in the data – should match number of
                                      // cars on HUD

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
        ParticipantData[] m_participants;
    };
}
