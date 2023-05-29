using System.Runtime.InteropServices;

namespace F1Telemetry.Struct
{
    public struct ParticipantData
    {
        sbyte m_aiControlled; // Whether the vehicle is AI (1) or Human (0) controlled
        sbyte m_driverId; // Driver id - see appendix, 255 if network human
        sbyte m_networkId; // Network id – unique identifier for network players
        sbyte m_teamId; // Team id - see appendix
        sbyte m_myTeam; // My team flag – 1 = My Team, 0 = otherwise
        sbyte m_raceNumber; // Race number of the car
        sbyte m_nationality; // Nationality of the driver
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        char[] m_name; // Name of participant in UTF-8 format – null terminated
                                        // Will be truncated with ... (U+2026) if too long
        sbyte m_yourTelemetry; // The player's UDP setting, 0 = restricted, 1 = public
    };
}
