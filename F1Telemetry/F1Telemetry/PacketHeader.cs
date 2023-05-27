namespace F1Telemetry
{
    struct PacketHeader
    {
        UInt16  m_packetFormat; // 2022
        uint   m_gameMajorVersion; // Game major version - "X.00"
        uint m_gameMinorVersion; // Game minor version - "1.XX"
        uint m_packetVersion; // Version of this packet type, all start from 1
        uint m_packetId; // Identifier for the packet type, see below
        UInt64 m_sessionUID; // Unique identifier for the session
        float m_sessionTime; // Session timestamp
        UInt32 m_frameIdentifier; // Identifier for the frame the data was retrieved on
        uint m_playerCarIndex; // Index of player's car in the array
        uint m_secondaryPlayerCarIndex; // Index of secondary player's car in the array (splitscreen)
    }
}