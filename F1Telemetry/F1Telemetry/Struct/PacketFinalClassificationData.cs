using System.Runtime.InteropServices;

namespace F1Telemetry.Struct
{
    public struct PacketFinalClassificationData
    {
        sbyte m_numCars; // Number of cars in the final classification
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
        FinalClassificationData[] m_classificationData;
    };
}
