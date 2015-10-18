using ICities;
using ColossalFramework;

namespace DifficultyTuningMod.DifficultyOptions
{
    public class ResidentialTargetLandValue : DifficultyParameterMultiple
    {
        public ResidentialTargetLandValue() : base() { }

        protected override void InitValues()
        {
            nMin = -5;
            nMax = 10;
        }

        protected override int getValue(int n, Level level)
        {
            switch (level)
            {
                case Level.Level2:
                    return 2 + 4 * n;
                case Level.Level3:
                    return 14 + 7 * n;
                case Level.Level4:
                    return 31 + 10 * n;
                case Level.Level5:
                    return 49 + 12 * n;
            }

            return InvalidValue;
        }

        protected override int getTooLowValue(int n, Level level)
        {
            return getValue(n, level) - 10;
        }
    }
}