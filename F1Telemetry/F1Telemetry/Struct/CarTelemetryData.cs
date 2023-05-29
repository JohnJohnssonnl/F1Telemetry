using System.Runtime.InteropServices;

namespace F1Telemetry.Struct
{
    public struct CarTelemetryData
    {
        private  ushort m_speed; // Speed of car in kilometres per hour
        private  float m_throttle; // Amount of throttle applied (0.0 to 1.0)
        private  float m_steer; // Steering (-1.0 (full lock left) to 1.0 (full lock right))
        private  float m_brake; // Amount of brake applied (0.0 to 1.0)
        private  sbyte m_clutch; // Amount of clutch applied (0 to 100)
        private  int m_gear; // Gear selected (1-8, N=0, R=-1)
        private  ushort m_engineRPM; // Engine RPM
        private  sbyte m_drs; // 0 = off, 1 = on
        private  sbyte m_revLightsPercent; // Rev lights indicator (percentage)
        private  ushort m_revLightsBitValue; // Rev lights (bit 0 = leftmost LED, bit 14 = rightmost LED)
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        private  ushort[] m_brakesTemperature; // Brakes temperature (celsius)
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        private  sbyte[] m_tyresSurfaceTemperature; // Tyres surface temperature (celsius)
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        private sbyte[] m_tyresInnerTemperature; // Tyres inner temperature (celsius)
        private  ushort m_engineTemperature; // Engine temperature (celsius)
        private  float m_tyresPressure; // Tyres pressure (PSI)
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        private sbyte[] m_surfaceType; // Driving surface, see appendices
    };
}
