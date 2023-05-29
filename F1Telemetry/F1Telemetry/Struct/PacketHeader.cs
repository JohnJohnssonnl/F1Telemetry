namespace F1Telemetry.Struct
{
    public struct PacketHeader
    {
        public ushort m_packetFormat; // 2022
        public sbyte m_gameMajorVersion; // Game major version - "X.00"
        public sbyte m_gameMinorVersion; // Game minor version - "1.XX"
        public sbyte m_packetVersion; // Version of this packet type, all start from 1
        public sbyte m_packetId; // Identifier for the packet type, see below
        public ulong m_sessionUID; // Unique identifier for the session
        public float m_sessionTime; // Session timestamp
        public sbyte m_frameIdentifier; // Identifier for the frame the data was retrieved on
        public sbyte m_playerCarIndex; // Index of player's car in the array
        public sbyte m_secondaryPlayerCarIndex; // Index of secondary player's car in the array (splitscreen)
    }
}