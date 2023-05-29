using System.Runtime.InteropServices;

namespace F1Telemetry.Struct
{
    public struct LobbyInfoData
    {
        sbyte m_aiControlled; // Whether the vehicle is AI (1) or Human (0) controlled
        sbyte m_teamId; // Team id - see appendix (255 if no team currently selected)
        sbyte m_nationality; // Nationality of the driver
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        char[] m_name; // Name of participant in UTF-8 format – null terminated
                                // Will be truncated with ... (U+2026) if too long

        sbyte m_carNumber; // Car number of the player
        sbyte m_readyStatus; // 0 = not ready, 1 = ready, 2 = spectating
    };
}
