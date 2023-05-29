using F1Telemetry.Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Telemetry.Kernel
{
    internal class ApplicationPacketProcessor_PacketSessionData : ApplicationPacketProcessor
    {
        public override Enum.PacketType PacketType()
        {
            return Enum.PacketType.PacketSessionData;
        }

        public override void Run(dynamic _data)
        {
            Appl.ApplicationData.PacketSessionData.Add(UDPHelper.ByteArrayToPacketHeader(_data, typeof(PacketSessionData)));
        }
    }
}
