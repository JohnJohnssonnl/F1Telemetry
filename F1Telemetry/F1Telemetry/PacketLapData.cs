namespace F1Telemetry
{
    internal struct PacketLapData
    {
        private PacketHeader m_header; // Header
        private readonly LapData[] m_lapData; // Lap data for all cars on track
        private readonly uint m_timeTrialPBCarIdx; // Index of Personal Best car in time trial (255 if invalid)
        private readonly uint m_timeTrialRivalCarIdx; // Index of Rival car in time trial (255 if invalid)
    };
}
