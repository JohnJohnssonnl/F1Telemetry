namespace F1Telemetry
{
    internal struct ParticipantData
    {
        private uint m_aiControlled; // Whether the vehicle is AI (1) or Human (0) controlled
        private uint m_driverId; // Driver id - see appendix, 255 if network human
        private uint m_networkId; // Network id – unique identifier for network players
        private uint m_teamId; // Team id - see appendix
        private uint m_myTeam; // My team flag – 1 = My Team, 0 = otherwise
        private uint m_raceNumber; // Race number of the car
        private uint m_nationality; // Nationality of the driver
        private readonly char[] m_name; // Name of participant in UTF-8 format – null terminated
                                          // Will be truncated with ... (U+2026) if too long

        private uint m_yourTelemetry; // The player's UDP setting, 0 = restricted, 1 = public
    };
}
