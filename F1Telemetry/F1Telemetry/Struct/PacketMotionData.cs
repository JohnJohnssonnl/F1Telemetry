using System.Runtime.InteropServices;

namespace F1Telemetry.Struct
{
    public struct PacketMotionData
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
        CarMotionData[] m_carMotionData; // Data for all cars on track
                                         // Extra player car ONLY data
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        float[] m_suspensionPosition; // Note: All wheel arrays have the following order:
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        float[] m_suspensionVelocity; // RL, RR, FL, FR
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        float[] m_suspensionAcceleration; // RL, RR, FL, FR
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        float[] m_wheelSpeed; // Speed of each wheel
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        float[] m_wheelSlip; // Slip ratio for each wheel
        float m_localVelocityX; // Velocity in local space
        float m_localVelocityY; // Velocity in local space
        float m_localVelocityZ; // Velocity in local space
        float m_angularVelocityX; // Angular velocity x-component
        float m_angularVelocityY; // Angular velocity y-component
        float m_angularVelocityZ; // Angular velocity z-component
        float m_angularAccelerationX; // Angular velocity x-component
        float m_angularAccelerationY; // Angular velocity y-component
        float m_angularAccelerationZ; // Angular velocity z-component
        float m_frontWheelsAngle; // Current front wheels angle in radians
    }
}
