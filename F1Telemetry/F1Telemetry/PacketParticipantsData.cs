namespace F1Telemetry
{
    internal struct PacketParticipantsData
    {
        private PacketHeader m_header; // Header
        private uint m_numActiveCars; // Number of active cars in the data – should match number of
                                      // cars on HUD

        private ParticipantData[] m_participants;
    };
}
