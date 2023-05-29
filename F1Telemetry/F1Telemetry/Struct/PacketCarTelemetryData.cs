using System.Runtime.InteropServices;

namespace F1Telemetry.Struct
{
    public struct PacketCarTelemetryData
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
        CarTelemetryData[] m_carTelemetryData;
        sbyte m_mfdPanelIndex; // Index of MFD panel open - 255 = MFD closed
                               // Single player, race – 0 = Car setup, 1 = Pits
                               // 2 = Damage, 3 = Engine, 4 = Temperatures
                               // May vary depending on game mode

        sbyte m_mfdPanelIndexSecondaryPlayer;   // See above
        sbyte m_suggestedGear;                  // Suggested gear for the player (1-8)
                                                // 0 if no gear suggested
    };
}
