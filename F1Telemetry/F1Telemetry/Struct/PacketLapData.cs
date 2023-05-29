using System.Runtime.InteropServices;

namespace F1Telemetry.Struct
{
    public struct PacketLapData
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
        LapData[] m_lapData; // Lap data for all cars on track
        sbyte m_timeTrialPBCarIdx; // Index of Personal Best car in time trial (255 if invalid)
        sbyte m_timeTrialRivalCarIdx; // Index of Rival car in time trial (255 if invalid)
    };
}
