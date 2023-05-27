namespace F1Telemetry
{
    internal struct CarDamageData
    {
        private readonly float[] m_tyresWear; // Tyre wear (percentage)
        private readonly uint[] m_tyresDamage; // Tyre damage (percentage)
        private readonly uint[] m_brakesDamage; // Brakes damage (percentage)
        private readonly uint m_frontLeftWingDamage; // Front left wing damage (percentage)
        private readonly uint m_frontRightWingDamage; // Front right wing damage (percentage)
        private readonly uint m_rearWingDamage; // Rear wing damage (percentage)
        private readonly uint m_floorDamage; // Floor damage (percentage)
        private readonly uint m_diffuserDamage; // Diffuser damage (percentage)
        private readonly uint m_sidepodDamage; // Sidepod damage (percentage)
        private readonly uint m_drsFault; // Indicator for DRS fault, 0 = OK, 1 = fault
        private readonly uint m_ersFault; // Indicator for ERS fault, 0 = OK, 1 = fault
        private readonly uint m_gearBoxDamage; // Gear box damage (percentage)
        private readonly uint m_engineDamage; // Engine damage (percentage)
        private readonly uint m_engineMGUHWear; // Engine wear MGU-H (percentage)
        private readonly uint m_engineESWear; // Engine wear ES (percentage)
        private readonly uint m_engineCEWear; // Engine wear CE (percentage)
        private readonly uint m_engineICEWear; // Engine wear ICE (percentage)
        private readonly uint m_engineMGUKWear; // Engine wear MGU-K (percentage)
        private readonly uint m_engineTCWear; // Engine wear TC (percentage)
        private readonly uint m_engineBlown; // Engine blown, 0 = OK, 1 = fault
        private readonly uint m_engineSeized; // Engine seized, 0 = OK, 1 = fault
    }
}
