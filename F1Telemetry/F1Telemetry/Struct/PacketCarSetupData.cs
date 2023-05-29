using System.Runtime.InteropServices;

namespace F1Telemetry.Struct
{
    public struct PacketCarSetupData
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
        CarSetupData[] m_carSetups;
    };
}
