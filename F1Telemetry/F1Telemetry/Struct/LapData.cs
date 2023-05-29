namespace F1Telemetry.Struct
{
    public struct LapData
    {
        sbyte m_lastLapTimeInMS; // Last lap time in milliseconds
        sbyte m_currentLapTimeInMS; // Current time around the lap in milliseconds
        ushort m_sector1TimeInMS; // Sector 1 time in milliseconds
        ushort m_sector2TimeInMS; // Sector 2 time in milliseconds
        float m_lapDistance; // Distance vehicle is around current lap in metres – could
                                              // be negative if line hasn’t been crossed yet

        float m_totalDistance; // Total distance travelled in session in metres – could
                                                // be negative if line hasn’t been crossed yet

        float m_safetyCarDelta; // Delta in seconds for safety car
        sbyte m_carPosition; // Car race position
        sbyte m_currentLapNum; // Current lap number
        sbyte m_pitStatus; // 0 = none, 1 = pitting, 2 = in pit area
        sbyte m_numPitStops; // Number of pit stops taken in this race
        sbyte m_sector; // 0 = sector1, 1 = sector2, 2 = sector3
        sbyte m_currentLapInvalid; // Current lap invalid - 0 = valid, 1 = invalid
        sbyte m_penalties; // Accumulated time penalties in seconds to be added
        sbyte m_warnings; // Accumulated number of warnings issued
        sbyte m_numUnservedDriveThroughPens; // Num drive through pens left to serve
        sbyte m_numUnservedStopGoPens; // Num stop go pens left to serve
        sbyte m_gridPosition; // Grid position the vehicle started the race in
        sbyte m_driverStatus; // Status of driver - 0 = in garage, 1 = flying lap
                              // 2 = in lap, 3 = out lap, 4 = on track

        sbyte m_resultStatus; // Result status - 0 = invalid, 1 = inactive, 2 = active
                             // 3 = finished, 4 = didnotfinish, 5 = disqualified
                             // 6 = not classified, 7 = retired

        sbyte m_pitLaneTimerActive; // Pit lane timing, 0 = inactive, 1 = active
        ushort m_pitLaneTimeInLaneInMS; // If active, the current time spent in the pit lane in ms
        ushort m_pitStopTimerInMS; // Time of the actual pit stop in ms
        sbyte m_pitStopShouldServePen; // Whether the car should serve a penalty at this stop
    };
}
