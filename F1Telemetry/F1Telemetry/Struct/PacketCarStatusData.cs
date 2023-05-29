using System.Runtime.InteropServices;

namespace F1Telemetry.Struct
{
    public struct PacketCarStatusData
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
        CarStatusData[] m_carStatusData;
    };
}
