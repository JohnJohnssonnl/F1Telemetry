namespace F1Telemetry
{
    internal struct PacketCarSetupData
    {
        private PacketHeader m_header; // Header
        private readonly CarSetupData[] m_carSetups;
    };
}
