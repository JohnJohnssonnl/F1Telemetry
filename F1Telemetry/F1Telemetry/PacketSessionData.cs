namespace F1Telemetry
{
    internal class PacketSessionData
    {
        PacketHeader m_header; // Header
        uint m_weather; // Weather - 0 = clear, 1 = light cloud, 2 = overcast
                        // 3 = light rain, 4 = heavy rain, 5 = storm
        int m_trackTemperature; // Track temp. in degrees celsius
        int m_airTemperature; // Air temp. in degrees celsius
        uint m_totalLaps; // Total number of laps in this race
        UInt16 m_trackLength; // Track length in metres
        uint m_sessionType; // 0 = unknown, 1 = P1, 2 = P2, 3 = P3, 4 = Short P
                            // 5 = Q1, 6 = Q2, 7 = Q3, 8 = Short Q, 9 = OSQ
                            // 10 = R, 11 = R2, 12 = R3, 13 = Time Trial
        int m_trackId; // -1 for unknown, see appendix
        uint m_formula; // Formula, 0 = F1 Modern, 1 = F1 Classic, 2 = F2,
                        // 3 = F1 Generic, 4 = Beta, 5 = Supercars
                        // 6 = Esports, 7 = F2 2021
        UInt16 m_sessionTimeLeft; // Time left in session in seconds
        UInt16 m_sessionDuration; // Session duration in seconds
        uint m_pitSpeedLimit; // Pit speed limit in kilometres per hour
        uint m_gamePaused; // Whether the game is paused – network game only
        uint m_isSpectating; // Whether the player is spectating
        uint m_spectatorCarIndex; // Index of the car being spectated
        uint m_sliProNativeSupport; // SLI Pro support, 0 = inactive, 1 = active
        uint m_numMarshalZones; // Number of marshal zones to follow
        MarshalZone[] m_marshalZones; // List of marshal zones – max 21
        uint m_safetyCarStatus; // 0 = no safety car, 1 = full
                                // 2 = virtual, 3 = formation lap
        uint m_networkGame; // 0 = offline, 1 = online
        uint m_numWeatherForecastSamples; // Number of weather samples to follow
        WeatherForecastSample[] m_weatherForecastSamples; // Array of weather forecast samples
        uint m_forecastAccuracy; // 0 = Perfect, 1 = Approximate
        uint m_aiDifficulty; // AI Difficulty rating – 0-110
        UInt32 m_seasonLinkIdentifier; // Identifier for season - persists across saves
        UInt32 m_weekendLinkIdentifier; // Identifier for weekend - persists across saves
        UInt32 m_sessionLinkIdentifier; // Identifier for session - persists across saves
        uint m_pitStopWindowIdealLap; // Ideal lap to pit on for current strategy (player)
        uint m_pitStopWindowLatestLap; // Latest lap to pit on for current strategy (player)
        uint m_pitStopRejoinPosition; // Predicted position to rejoin at (player)
        uint m_steeringAssist; // 0 = off, 1 = on
        uint m_brakingAssist; // 0 = off, 1 = low, 2 = medium, 3 = high
        uint m_gearboxAssist; // 1 = manual, 2 = manual & suggested gear, 3 = auto
        uint m_pitAssist; // 0 = off, 1 = on
        uint m_pitReleaseAssist; // 0 = off, 1 = on
        uint m_ERSAssist; // 0 = off, 1 = on
        uint m_DRSAssist; // 0 = off, 1 = on
        uint m_dynamicRacingLine; // 0 = off, 1 = corners only, 2 = full
        uint m_dynamicRacingLineType; // 0 = 2D, 1 = 3D
        uint m_gameMode; // Game mode id - see appendix
        uint m_ruleSet; // Ruleset - see appendix
        UInt32 m_timeOfDay; // Local time of day - minutes since midnight
        uint m_sessionLength; // 0 = None, 2 = Very Short, 3 = Short, 4 = Medium
                               // 5 = Medium Long, 6 = Long, 7 = Full
    };
}
