using System.Runtime.InteropServices;

namespace F1Telemetry.Struct
{
    public struct PacketSessionData
    {
        sbyte m_weather; // Weather - 0 = clear, 1 = light cloud, 2 = overcast
                        // 3 = light rain, 4 = heavy rain, 5 = storm
        int m_trackTemperature; // Track temp. in degrees celsius
        int m_airTemperature; // Air temp. in degrees celsius
        sbyte m_totalLaps; // Total number of laps in this race
        ushort m_trackLength; // Track length in metres
        sbyte m_sessionType; // 0 = unknown, 1 = P1, 2 = P2, 3 = P3, 4 = Short P
                            // 5 = Q1, 6 = Q2, 7 = Q3, 8 = Short Q, 9 = OSQ
                            // 10 = R, 11 = R2, 12 = R3, 13 = Time Trial
        int m_trackId; // -1 for unknown, see appendix
        sbyte m_formula; // Formula, 0 = F1 Modern, 1 = F1 Classic, 2 = F2,
                        // 3 = F1 Generic, 4 = Beta, 5 = Supercars
                        // 6 = Esports, 7 = F2 2021
        ushort m_sessionTimeLeft; // Time left in session in seconds
        ushort m_sessionDuration; // Session duration in seconds
        sbyte m_pitSpeedLimit; // Pit speed limit in kilometres per hour
        sbyte m_gamePaused; // Whether the game is paused – network game only
        sbyte m_isSpectating; // Whether the player is spectating
        sbyte m_spectatorCarIndex; // Index of the car being spectated
        sbyte m_sliProNativeSupport; // SLI Pro support, 0 = inactive, 1 = active
        sbyte m_numMarshalZones; // Number of marshal zones to follow
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
        MarshalZone[] m_marshalZones; // List of marshal zones – max 21
        sbyte m_safetyCarStatus; // 0 = no safety car, 1 = full
                                 // 2 = virtual, 3 = formation lap
        sbyte m_networkGame; // 0 = offline, 1 = online
        sbyte m_numWeatherForecastSamples; // Number of weather samples to follow
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)]
        WeatherForecastSample[] m_weatherForecastSamples; // Array of weather forecast samples
        sbyte m_forecastAccuracy; // 0 = Perfect, 1 = Approximate
        sbyte m_aiDifficulty; // AI Difficulty rating – 0-110
        sbyte m_seasonLinkIdentifier; // Identifier for season - persists across saves
        sbyte m_weekendLinkIdentifier; // Identifier for weekend - persists across saves
        sbyte m_sessionLinkIdentifier; // Identifier for session - persists across saves
        sbyte m_pitStopWindowIdealLap; // Ideal lap to pit on for current strategy (player)
        sbyte m_pitStopWindowLatestLap; // Latest lap to pit on for current strategy (player)
        sbyte m_pitStopRejoinPosition; // Predicted position to rejoin at (player)
        sbyte m_steeringAssist; // 0 = off, 1 = on
        sbyte m_brakingAssist; // 0 = off, 1 = low, 2 = medium, 3 = high
        sbyte m_gearboxAssist; // 1 = manual, 2 = manual & suggested gear, 3 = auto
        sbyte m_pitAssist; // 0 = off, 1 = on
        sbyte m_pitReleaseAssist; // 0 = off, 1 = on
        sbyte m_ERSAssist; // 0 = off, 1 = on
        sbyte m_DRSAssist; // 0 = off, 1 = on
        sbyte m_dynamicRacingLine; // 0 = off, 1 = corners only, 2 = full
        sbyte m_dynamicRacingLineType; // 0 = 2D, 1 = 3D
        sbyte m_gameMode; // Game mode id - see appendix
        sbyte m_ruleSet; // Ruleset - see appendix
        sbyte m_timeOfDay; // Local time of day - minutes since midnight
        sbyte m_sessionLength; // 0 = None, 2 = Very Short, 3 = Short, 4 = Medium
                              // 5 = Medium Long, 6 = Long, 7 = Full*/
    };
}
