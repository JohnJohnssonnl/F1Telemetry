namespace F1Telemetry
{
    internal struct PacketCarDamageData
    {
        private PacketHeader m_header; // Header
        private readonly CarDamageData[] m_carDamageData;
    };
}
