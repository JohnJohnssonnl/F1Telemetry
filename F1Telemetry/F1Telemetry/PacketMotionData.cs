namespace F1Telemetry
{
    internal struct PacketMotionData
    {
        private PacketHeader m_header; // Header
        private readonly CarMotionData[] m_carMotionData; // Data for all cars on track
                                                          // Extra player car ONLY data

        private readonly float[] m_suspensionPosition; // Note: All wheel arrays have the following order:
        private readonly float[] m_suspensionVelocity; // RL, RR, FL, FR
        private readonly float[] m_suspensionAcceleration; // RL, RR, FL, FR
        private readonly float[] m_wheelSpeed; // Speed of each wheel
        private readonly float[] m_wheelSlip; // Slip ratio for each wheel
        private readonly float m_localVelocityX; // Velocity in local space
        private readonly float m_localVelocityY; // Velocity in local space
        private readonly float m_localVelocityZ; // Velocity in local space
        private readonly float m_angularVelocityX; // Angular velocity x-component
        private readonly float m_angularVelocityY; // Angular velocity y-component
        private readonly float m_angularVelocityZ; // Angular velocity z-component
        private readonly float m_angularAccelerationX; // Angular velocity x-component
        private readonly float m_angularAccelerationY; // Angular velocity y-component
        private readonly float m_angularAccelerationZ; // Angular velocity z-component
        private readonly float m_frontWheelsAngle; // Current front wheels angle in radians
    }
}
