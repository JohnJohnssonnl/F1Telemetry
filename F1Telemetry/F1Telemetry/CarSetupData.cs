namespace F1Telemetry
{
    internal struct CarSetupData
    {
        private uint m_frontWing; // Front wing aero
        private uint m_rearWing; // Rear wing aero
        private uint m_onThrottle; // Differential adjustment on throttle (percentage)
        private uint m_offThrottle; // Differential adjustment off throttle (percentage)
        private readonly float m_frontCamber; // Front camber angle (suspension geometry)
        private readonly float m_rearCamber; // Rear camber angle (suspension geometry)
        private readonly float m_frontToe; // Front toe angle (suspension geometry)
        private readonly float m_rearToe; // Rear toe angle (suspension geometry)
        private uint m_frontSuspension; // Front suspension
        private uint m_rearSuspension; // Rear suspension
        private uint m_frontAntiRollBar; // Front anti-roll bar
        private uint m_rearAntiRollBar; // Front anti-roll bar
        private uint m_frontSuspensionHeight; // Front ride height
        private uint m_rearSuspensionHeight; // Rear ride height
        private uint m_brakePressure; // Brake pressure (percentage)
        private uint m_brakeBias; // Brake bias (percentage)
        private readonly float m_rearLeftTyrePressure; // Rear left tyre pressure (PSI)
        private readonly float m_rearRightTyrePressure; // Rear right tyre pressure (PSI)
        private readonly float m_frontLeftTyrePressure; // Front left tyre pressure (PSI)
        private readonly float m_frontRightTyrePressure; // Front right tyre pressure (PSI)
        private uint m_ballast; // Ballast
        private readonly float m_fuelLoad; // Fuel load
    };
}
