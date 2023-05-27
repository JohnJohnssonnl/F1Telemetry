namespace F1Telemetry
{
    internal struct CarTelemetryData
    {
        private readonly ushort m_speed; // Speed of car in kilometres per hour
        private readonly float m_throttle; // Amount of throttle applied (0.0 to 1.0)
        private readonly float m_steer; // Steering (-1.0 (full lock left) to 1.0 (full lock right))
        private readonly float m_brake; // Amount of brake applied (0.0 to 1.0)
        private readonly uint m_clutch; // Amount of clutch applied (0 to 100)
        private readonly int m_gear; // Gear selected (1-8, N=0, R=-1)
        private readonly ushort m_engineRPM; // Engine RPM
        private readonly uint m_drs; // 0 = off, 1 = on
        private readonly uint m_revLightsPercent; // Rev lights indicator (percentage)
        private readonly ushort m_revLightsBitValue; // Rev lights (bit 0 = leftmost LED, bit 14 = rightmost LED)
        private readonly ushort[] m_brakesTemperature; // Brakes temperature (celsius)
        private readonly uint[] m_tyresSurfaceTemperature; // Tyres surface temperature (celsius)
        private readonly uint[] m_tyresInnerTemperature; // Tyres inner temperature (celsius)
        private readonly ushort m_engineTemperature; // Engine temperature (celsius)
        private readonly float m_tyresPressure; // Tyres pressure (PSI)
        private readonly uint[] m_surfaceType; // Driving surface, see appendices
    };
}
