namespace F1Telemetry
{
    internal struct LapHistoryData
    {
        private readonly uint m_lapTimeInMS; // Lap time in milliseconds
        private readonly ushort m_sector1TimeInMS; // Sector 1 time in milliseconds
        private readonly ushort m_sector2TimeInMS; // Sector 2 time in milliseconds
        private readonly ushort m_sector3TimeInMS; // Sector 3 time in milliseconds
        private readonly uint m_lapValidBitFlags; // 0x01 bit set-lap valid, 0x02 bit set-sector 1 valid
                                                  // 0x04 bit set-sector 2 valid, 0x08 bit set-sector 3 valid
    };
}
