using System.Runtime.InteropServices;

namespace F1Telemetry.Struct
{
    public struct FinalClassificationData
    {
        sbyte m_position; // Finishing position
        sbyte m_numLaps; // Number of laps completed
        sbyte m_gridPosition; // Grid position of the car
        sbyte m_points; // Number of points scored
        sbyte m_numPitStops; // Number of pit stops made
        sbyte m_resultStatus; // Result status - 0 = invalid, 1 = inactive, 2 = active
                              // 3 = finished, 4 = didnotfinish, 5 = disqualified
                              // 6 = not classified, 7 = retired

        sbyte m_bestLapTimeInMS; // Best lap time of the session in milliseconds
        double m_totalRaceTime; // Total race time in seconds without penalties
        sbyte m_penaltiesTime; // Total penalties accumulated in seconds
        sbyte m_numPenalties; // Number of penalties applied to this driver
        sbyte m_numTyreStints; // Number of tyres stints up to maximum
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        sbyte[] m_tyreStintsActual; // Actual tyres used by this driver
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        sbyte[] m_tyreStintsVisual; // Visual tyres used by this driver
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        sbyte[] m_tyreStintsEndLaps; // The lap number stints end on
    };
}
