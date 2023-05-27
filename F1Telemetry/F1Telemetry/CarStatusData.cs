namespace F1Telemetry
{
    internal struct CarStatusData
    {
        private readonly uint m_tractionControl; // Traction control - 0 = off, 1 = medium, 2 = full
        private readonly uint m_antiLockBrakes; // 0 (off) - 1 (on)
        private readonly uint m_fuelMix; // Fuel mix - 0 = lean, 1 = standard, 2 = rich, 3 = max
        private readonly uint m_frontBrakeBias; // Front brake bias (percentage)
        private readonly uint m_pitLimiterStatus; // Pit limiter status - 0 = off, 1 = on
        private readonly float m_fuelInTank; // Current fuel mass
        private readonly float m_fuelCapacity; // Fuel capacity
        private readonly float m_fuelRemainingLaps; // Fuel remaining in terms of laps (value on MFD)
        private readonly ushort m_maxRPM; // Cars max RPM, point of rev limiter
        private readonly ushort m_idleRPM; // Cars idle RPM
        private readonly uint m_maxGears; // Maximum number of gears
        private readonly uint m_drsAllowed; // 0 = not allowed, 1 = allowed
        private readonly ushort m_drsActivationDistance; // 0 = DRS not available, non-zero - DRS will be available
                                                         // in [X] metres

        private readonly uint m_actualTyreCompound; // F1 Modern - 16 = C5, 17 = C4, 18 = C3, 19 = C2, 20 = C1
                                                    // 7 = inter, 8 = wet
                                                    // F1 Classic - 9 = dry, 10 = wet
                                                    // F2 – 11 = super soft, 12 = soft, 13 = medium, 14 = hard
                                                    // 15 = wet

        private readonly uint m_visualTyreCompound; // F1 visual (can be different from actual compound)
                                                    // 16 = soft, 17 = medium, 18 = hard, 7 = inter, 8 = wet
                                                    // F1 Classic – same as above
                                                    // F2 ‘19, 15 = wet, 19 – super soft, 20 = soft
                                                    // 21 = medium , 22 = hard

        private readonly uint m_tyresAgeLaps; // Age in laps of the current set of tyres
        private readonly int m_vehicleFiaFlags; // -1 = invalid/unknown, 0 = none, 1 = green
                                                // 2 = blue, 3 = yellow, 4 = red

        private readonly float m_ersStoreEnergy; // ERS energy store in Joules
        private readonly uint m_ersDeployMode; // ERS deployment mode, 0 = none, 1 = medium
                                               // 2 = hotlap, 3 = overtake

        private readonly float m_ersHarvestedThisLapMGUK; // ERS energy harvested this lap by MGU-K
        private readonly float m_ersHarvestedThisLapMGUH; // ERS energy harvested this lap by MGU-H
        private readonly float m_ersDeployedThisLap; // ERS energy deployed this lap
        private readonly uint m_networkPaused; // Whether the car is paused in a network game
    };
}
