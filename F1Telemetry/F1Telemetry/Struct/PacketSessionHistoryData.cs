using System.Runtime.InteropServices;

namespace F1Telemetry.Struct
{
    public struct PacketSessionHistoryData
    {
        private  uint m_carIdx; // Index of the car this lap data relates to
        private  uint m_numLaps; // Num laps in the data (including current partial lap)
        private  uint m_numTyreStints; // Number of tyre stints in the data
        private  uint m_bestLapTimeLapNum; // Lap the best lap time was achieved on
        private  uint m_bestSector1LapNum; // Lap the best Sector 1 time was achieved on
        private  uint m_bestSector2LapNum; // Lap the best Sector 2 time was achieved on
        private  uint m_bestSector3LapNum; // Lap the best Sector 3 time was achieved on
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
        private  LapHistoryData[] m_lapHistoryData; // 100 laps of data max
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        private  TyreStintHistoryData[] m_tyreStintsHistoryData;
    };
}
