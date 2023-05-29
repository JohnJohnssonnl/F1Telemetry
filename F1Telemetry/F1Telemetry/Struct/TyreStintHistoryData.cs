namespace F1Telemetry.Struct
{
    public struct TyreStintHistoryData
    {
        private  uint m_endLap; // Lap the tyre usage ends on (255 of current tyre)
        private  uint m_tyreActualCompound; // Actual tyres used by this driver
        private  uint m_tyreVisualCompound; // Visual tyres used by this driver
    };
}
