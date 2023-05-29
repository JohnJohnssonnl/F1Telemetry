using System.Runtime.InteropServices;

namespace F1Telemetry.Struct
{
    public struct PacketCarDamageData
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
        CarDamageData[] m_carDamageData;
    };
}
