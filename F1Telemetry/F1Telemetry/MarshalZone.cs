namespace F1Telemetry
{
    internal struct MarshalZone
    {
        private readonly float m_zoneStart; // Fraction (0..1) of way through the lap the marshal zone starts
        private readonly int m_zoneFlag; // -1 = invalid/unknown, 0 = none, 1 = green, 2 = blue, 3 = yellow, 4 = red
    };
}
