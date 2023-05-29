using System.Runtime.InteropServices;

namespace F1Telemetry.Struct
{
    public struct CarDamageData
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        float[] m_tyresWear; // Tyre wear (percentage)
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        sbyte[] m_tyresDamage; // Tyre damage (percentage)
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        sbyte[] m_brakesDamage; // Brakes damage (percentage)
        sbyte m_frontLeftWingDamage; // Front left wing damage (percentage)
        sbyte m_frontRightWingDamage; // Front right wing damage (percentage)
        sbyte m_rearWingDamage; // Rear wing damage (percentage)
        sbyte m_floorDamage; // Floor damage (percentage)
        sbyte m_diffuserDamage; // Diffuser damage (percentage)
        sbyte m_sidepodDamage; // Sidepod damage (percentage)
        sbyte m_drsFault; // Indicator for DRS fault, 0 = OK, 1 = fault
        sbyte m_ersFault; // Indicator for ERS fault, 0 = OK, 1 = fault
        sbyte m_gearBoxDamage; // Gear box damage (percentage)
        sbyte m_engineDamage; // Engine damage (percentage)
        sbyte m_engineMGUHWear; // Engine wear MGU-H (percentage)
        sbyte m_engineESWear; // Engine wear ES (percentage)
        sbyte m_engineCEWear; // Engine wear CE (percentage)
        sbyte m_engineICEWear; // Engine wear ICE (percentage)
        sbyte m_engineMGUKWear; // Engine wear MGU-K (percentage)
        sbyte m_engineTCWear; // Engine wear TC (percentage)
        sbyte m_engineBlown; // Engine blown, 0 = OK, 1 = fault
        sbyte m_engineSeized; // Engine seized, 0 = OK, 1 = fault
    }
}
