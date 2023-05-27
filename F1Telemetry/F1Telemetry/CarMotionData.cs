namespace F1Telemetry
{
    internal struct CarMotionData
    {
        private readonly float m_worldPositionX; // World space X position
        private readonly float m_worldPositionY; // World space Y position
        private readonly float m_worldPositionZ; // World space Z position
        private readonly float m_worldVelocityX; // Velocity in world space X
        private readonly float m_worldVelocityY; // Velocity in world space Y
        private readonly float m_worldVelocityZ; // Velocity in world space Z
        private readonly short m_worldForwardDirX; // World space forward X direction (normalised)
        private readonly short m_worldForwardDirY; // World space forward Y direction (normalised)
        private readonly short m_worldForwardDirZ; // World space forward Z direction (normalised)
        private readonly short m_worldRightDirX; // World space right X direction (normalised)
        private readonly short m_worldRightDirY; // World space right Y direction (normalised)
        private readonly short m_worldRightDirZ; // World space right Z direction (normalised)
        private readonly float m_gForceLateral; // Lateral G-Force component
        private readonly float m_gForceLongitudinal; // Longitudinal G-Force component
        private readonly float m_gForceVertical; // Vertical G-Force component
        private readonly float m_yaw; // Yaw angle in radians
        private readonly float m_pitch; // Pitch angle in radians
        private readonly float m_roll; // Roll angle in radians
    };
}
