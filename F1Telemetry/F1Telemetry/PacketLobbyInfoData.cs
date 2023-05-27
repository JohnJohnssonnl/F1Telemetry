namespace F1Telemetry
{
    internal struct PacketLobbyInfoData
    {
        private PacketHeader m_header; // Header
        uint m_numPlayers; // Number of players in the lobby data
        LobbyInfoData[] m_lobbyPlayers;
    }
}