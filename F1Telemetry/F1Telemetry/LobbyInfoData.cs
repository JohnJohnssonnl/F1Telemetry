namespace F1Telemetry
{
    internal struct LobbyInfoData
    {
        private readonly uint m_aiControlled; // Whether the vehicle is AI (1) or Human (0) controlled
        private readonly uint m_teamId; // Team id - see appendix (255 if no team currently selected)
        private readonly uint m_nationality; // Nationality of the driver
        private readonly char[] m_name; // Name of participant in UTF-8 format – null terminated
                                        // Will be truncated with ... (U+2026) if too long

        private readonly uint m_carNumber; // Car number of the player
        private readonly uint m_readyStatus; // 0 = not ready, 1 = ready, 2 = spectating
    };
}
