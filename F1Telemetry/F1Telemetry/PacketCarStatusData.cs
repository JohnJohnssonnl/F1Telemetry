namespace F1Telemetry
{
    internal struct PacketCarStatusData
    {
        private PacketHeader m_header; // Header
        private readonly CarStatusData[] m_carStatusData;
    };
}
