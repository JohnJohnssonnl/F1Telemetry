using System.Runtime.InteropServices;

namespace F1Telemetry.Struct
{
    public struct PacketLobbyInfoData
    {
        sbyte m_numPlayers; // Number of players in the lobby data
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
        LobbyInfoData[] m_lobbyPlayers;
    }
}