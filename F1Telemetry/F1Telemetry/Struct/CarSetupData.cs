namespace F1Telemetry.Struct
{
    public struct CarSetupData
    {
        sbyte m_frontWing; // Front wing aero
        sbyte m_rearWing; // Rear wing aero
        sbyte m_onThrottle; // Differential adjustment on throttle (percentage)
        sbyte m_offThrottle; // Differential adjustment off throttle (percentage)
        float m_frontCamber; // Front camber angle (suspension geometry)
        float m_rearCamber; // Rear camber angle (suspension geometry)
        float m_frontToe; // Front toe angle (suspension geometry)
        float m_rearToe; // Rear toe angle (suspension geometry)
        sbyte m_frontSuspension; // Front suspension
        sbyte m_rearSuspension; // Rear suspension
        sbyte m_frontAntiRollBar; // Front anti-roll bar
        sbyte m_rearAntiRollBar; // Front anti-roll bar
        sbyte m_frontSuspensionHeight; // Front ride height
        sbyte m_rearSuspensionHeight; // Rear ride height
        sbyte m_brakePressure; // Brake pressure (percentage)
        sbyte m_brakeBias; // Brake bias (percentage)
        float m_rearLeftTyrePressure; // Rear left tyre pressure (PSI)
        float m_rearRightTyrePressure; // Rear right tyre pressure (PSI)
        float m_frontLeftTyrePressure; // Front left tyre pressure (PSI)
        float m_frontRightTyrePressure; // Front right tyre pressure (PSI)
        sbyte m_ballast; // Ballast
        float m_fuelLoad; // Fuel load
    };
}
