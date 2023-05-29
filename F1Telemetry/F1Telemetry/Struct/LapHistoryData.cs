namespace F1Telemetry.Struct
{
    public struct LapHistoryData
    {
        sbyte m_lapTimeInMS;        // Lap time in milliseconds
        ushort m_sector1TimeInMS;   // Sector 1 time in milliseconds
        ushort m_sector2TimeInMS;   // Sector 2 time in milliseconds
        ushort m_sector3TimeInMS;   // Sector 3 time in milliseconds
        sbyte m_lapValidBitFlags;   // 0x01 bit set-lap valid, 0x02 bit set-sector 1 valid
                                    // 0x04 bit set-sector 2 valid, 0x08 bit set-sector 3 valid
    };
}
