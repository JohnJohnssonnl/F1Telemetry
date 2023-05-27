namespace F1Telemetry
{
    internal struct PacketSessionHistoryData
    {
        private PacketHeader m_header; // Header
        private readonly uint m_carIdx; // Index of the car this lap data relates to
        private readonly uint m_numLaps; // Num laps in the data (including current partial lap)
        private readonly uint m_numTyreStints; // Number of tyre stints in the data
        private readonly uint m_bestLapTimeLapNum; // Lap the best lap time was achieved on
        private readonly uint m_bestSector1LapNum; // Lap the best Sector 1 time was achieved on
        private readonly uint m_bestSector2LapNum; // Lap the best Sector 2 time was achieved on
        private readonly uint m_bestSector3LapNum; // Lap the best Sector 3 time was achieved on
        private readonly LapHistoryData[] m_lapHistoryData; // 100 laps of data max
        private readonly TyreStintHistoryData[] m_tyreStintsHistoryData;
    };
}
