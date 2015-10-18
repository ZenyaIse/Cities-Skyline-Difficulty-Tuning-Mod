using ICities;
using ColossalFramework;

namespace DifficultyTuningMod.DifficultyOptions
{
    public class CommercialTargetLandValue : DifficultyParameterMultiple
    {
        public CommercialTargetLandValue() : base() { }

        protected override void InitValues()
        {
            nMin = -4;
            nMax = 10;
        }

        protected override int getValue(int n, Level level)
        {
            switch (level)
            {
                case Level.Level2:
                    return 16 + 5 * n;
                case Level.Level3:
                    return 31 + 10 * n;
            }

            return InvalidValue;
        }

        protected override int getTooLowValue(int n, Level level)
        {
            return getValue(n, level) - 10;
        }
    }
}