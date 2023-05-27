namespace F1Telemetry
{
    internal struct FinalClassificationData
    {
        private uint m_position; // Finishing position
        private uint m_numLaps; // Number of laps completed
        private uint m_gridPosition; // Grid position of the car
        private uint m_points; // Number of points scored
        private uint m_numPitStops; // Number of pit stops made
        private uint m_resultStatus; // Result status - 0 = invalid, 1 = inactive, 2 = active
                                      // 3 = finished, 4 = didnotfinish, 5 = disqualified
                                      // 6 = not classified, 7 = retired

        private UInt32 m_bestLapTimeInMS; // Best lap time of the session in milliseconds
        private readonly double m_totalRaceTime; // Total race time in seconds without penalties
        private uint m_penaltiesTime; // Total penalties accumulated in seconds
        private uint m_numPenalties; // Number of penalties applied to this driver
        private uint m_numTyreStints; // Number of tyres stints up to maximum
        private uint[] m_tyreStintsActual; // Actual tyres used by this driver
        private uint[] m_tyreStintsVisual; // Visual tyres used by this driver
        private uint[] m_tyreStintsEndLaps; // The lap number stints end on
    };
}
