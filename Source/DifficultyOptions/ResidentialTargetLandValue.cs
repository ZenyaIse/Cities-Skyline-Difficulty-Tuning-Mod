using ICities;

namespace DifficultyTuningMod.DifficultyOptions
{
    public class ResidentialTargetLandValue : DifficultyParameterMultiple
    {
        public ResidentialTargetLandValue() : base() { }

        protected override void InitValues()
        {
            nMin = -6;
            nMax = 10;
        }

        protected override int getValue(int n, Level level)
        {
            switch (level)
            {
                case Level.Level2:
                    return 3 + 3 * n;
                case Level.Level3:
                    return 16 + 5 * n;
                case Level.Level4:
                    return 34 + 7 * n;
                case Level.Level5:
                    return 52 + 9 * n;
            }

            return InvalidValue;
        }

        protected override int getTooLowValue(int n, Level level)
        {
            return getValue(n, level) - 10;
        }
    }
}