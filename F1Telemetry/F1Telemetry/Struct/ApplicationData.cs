namespace F1Telemetry.Struct
{
    [Serializable]
    public struct ApplicationData
    {
        public List<PacketMotionData> PacketMotionData;
        public List<PacketSessionData> PacketSessionData;
        public List<PacketLapData> PacketLapData;
        public List<PacketParticipantsData> PacketParticipantsData;
        public List<PacketCarSetupData> PacketCarSetupData;
        public List<PacketCarTelemetryData> PacketCarTelemetryData;
        public List<PacketCarStatusData> PacketCarStatusData;
        public List<PacketFinalClassificationData> PacketFinalClassificationData;
        public List<PacketLobbyInfoData> PacketLobbyInfoData;
        public List<PacketCarDamageData> PacketCarDamageData;
        public List<PacketSessionHistoryData> PacketSessionHistoryData;

        public ApplicationData()
        {
            PacketMotionData = new List<PacketMotionData>();
            PacketSessionData = new List<PacketSessionData>();
            PacketLapData = new List<PacketLapData>();
            PacketParticipantsData = new List<PacketParticipantsData>();
            PacketCarSetupData = new List<PacketCarSetupData>();
            PacketCarTelemetryData = new List<PacketCarTelemetryData>();
            PacketCarStatusData = new List<PacketCarStatusData>();
            PacketFinalClassificationData = new List<PacketFinalClassificationData>();
            PacketLobbyInfoData = new List<PacketLobbyInfoData>();
            PacketCarDamageData = new List<PacketCarDamageData>();
            PacketSessionHistoryData = new List<PacketSessionHistoryData>();
        }
    }
}
