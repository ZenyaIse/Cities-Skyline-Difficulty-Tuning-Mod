using ICities;
using ColossalFramework;

namespace DifficultyTuningMod.DifficultyOptions
{
    public class CommercialTargetLandValue : DifficultyParameterMultiple
    {
        public CommercialTargetLandValue() : base() { }

        protected override void InitValues()
        {
            nMin = -3;
            nMax = 10;
        }

        protected override int getValue(int n, Level level)
        {
            switch (level)
            {
                case Level.Level2:
                    return 11 + 5 * n;
                case Level.Level3:
                    return 21 + 10 * n;
            }

            return InvalidValue;
        }

        protected override int getTooLowValue(int n, Level level)
        {
            switch (level)
            {
                case Level.Level2:
                    return 2 + 4 * n;
                case Level.Level3:
                    return 14 + 8 * n;
            }

            return InvalidValue;
        }
    }
}