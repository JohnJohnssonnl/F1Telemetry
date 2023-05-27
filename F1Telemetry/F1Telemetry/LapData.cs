namespace F1Telemetry
{
    internal struct LapData
    {
        private UInt32 m_lastLapTimeInMS; // Last lap time in milliseconds
        private UInt32 m_currentLapTimeInMS; // Current time around the lap in milliseconds
        private UInt16 m_sector1TimeInMS; // Sector 1 time in milliseconds
        private UInt16 m_sector2TimeInMS; // Sector 2 time in milliseconds
        private readonly float m_lapDistance; // Distance vehicle is around current lap in metres – could
                                              // be negative if line hasn’t been crossed yet

        private readonly float m_totalDistance; // Total distance travelled in session in metres – could
                                                // be negative if line hasn’t been crossed yet

        private readonly float m_safetyCarDelta; // Delta in seconds for safety car
        private uint m_carPosition; // Car race position
        private uint m_currentLapNum; // Current lap number
        private uint m_pitStatus; // 0 = none, 1 = pitting, 2 = in pit area
        private uint m_numPitStops; // Number of pit stops taken in this race
        private uint m_sector; // 0 = sector1, 1 = sector2, 2 = sector3
        private uint m_currentLapInvalid; // Current lap invalid - 0 = valid, 1 = invalid
        private uint m_penalties; // Accumulated time penalties in seconds to be added
        private uint m_warnings; // Accumulated number of warnings issued
        private uint m_numUnservedDriveThroughPens; // Num drive through pens left to serve
        private uint m_numUnservedStopGoPens; // Num stop go pens left to serve
        private uint m_gridPosition; // Grid position the vehicle started the race in
        private uint m_driverStatus; // Status of driver - 0 = in garage, 1 = flying lap
                                      // 2 = in lap, 3 = out lap, 4 = on track

        private uint m_resultStatus; // Result status - 0 = invalid, 1 = inactive, 2 = active
                                      // 3 = finished, 4 = didnotfinish, 5 = disqualified
                                      // 6 = not classified, 7 = retired

        private uint m_pitLaneTimerActive; // Pit lane timing, 0 = inactive, 1 = active
        private UInt16 m_pitLaneTimeInLaneInMS; // If active, the current time spent in the pit lane in ms
        private UInt16 m_pitStopTimerInMS; // Time of the actual pit stop in ms
        private uint m_pitStopShouldServePen; // Whether the car should serve a penalty at this stop
    };
}
