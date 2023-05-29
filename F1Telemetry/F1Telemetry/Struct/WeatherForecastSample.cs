namespace F1Telemetry.Struct
{
    public struct WeatherForecastSample
    {
        sbyte m_sessionType; // 0 = unknown, 1 = P1, 2 = P2, 3 = P3, 4 = Short P, 5 = Q1
                             // 6 = Q2, 7 = Q3, 8 = Short Q, 9 = OSQ, 10 = R, 11 = R2
                             // 12 = R3, 13 = Time Trial

        sbyte m_timeOffset; // Time in minutes the forecast is for
        sbyte m_weather; // Weather - 0 = clear, 1 = light cloud, 2 = overcast
                                // 3 = light rain, 4 = heavy rain, 5 = storm

        int m_trackTemperature; // Track temp. in degrees Celsius
        int m_trackTemperatureChange; // Track temp. change – 0 = up, 1 = down, 2 = no change
        int m_airTemperature; // Air temp. in degrees celsius
        int m_airTemperatureChange; // Air temp. change – 0 = up, 1 = down, 2 = no change
        sbyte m_rainPercentage; // Rain percentage (0-100)
    };
}
