namespace F1Telemetry
{
    internal struct PacketCarTelemetryData
    {
        private PacketHeader m_header; // Header
        private readonly CarTelemetryData[] m_carTelemetryData;
        private readonly uint m_mfdPanelIndex; // Index of MFD panel open - 255 = MFD closed
                                               // Single player, race – 0 = Car setup, 1 = Pits
                                               // 2 = Damage, 3 = Engine, 4 = Temperatures
                                               // May vary depending on game mode

        private readonly uint m_mfdPanelIndexSecondaryPlayer; // See above
        private readonly int m_suggestedGear; // Suggested gear for the player (1-8)
                                              // 0 if no gear suggested
    };
}
