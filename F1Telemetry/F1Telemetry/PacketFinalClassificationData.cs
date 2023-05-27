namespace F1Telemetry
{
    internal struct PacketFinalClassificationData
    {
        private PacketHeader m_header; // Header
        private readonly uint m_numCars; // Number of cars in the final classification
        private readonly FinalClassificationData[] m_classificationData;
    };
}
