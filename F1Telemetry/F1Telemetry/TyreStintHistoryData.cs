namespace F1Telemetry
{
    internal struct TyreStintHistoryData
    {
        private readonly uint m_endLap; // Lap the tyre usage ends on (255 of current tyre)
        private readonly uint m_tyreActualCompound; // Actual tyres used by this driver
        private readonly uint m_tyreVisualCompound; // Visual tyres used by this driver
    };
}
