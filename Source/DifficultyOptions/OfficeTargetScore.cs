using ICities;

namespace DifficultyTuningMod.DifficultyOptions
{
    public class OfficeTargetScore : DifficultyParameterMultiple
    {
        public OfficeTargetScore() : base() { }

        protected override void InitValues()
        {
            nMin = -8;
            nMax = 10;
        }

        protected override int getValue(int n, Level level)
        {
            switch (level)
            {
                case Level.Level2:
                    return 40 + 5 * n;
                case Level.Level3:
                    return 80 + 10 * n;
            }

            return InvalidValue;
        }

        protected override int getTooLowValue(int n, Level level)
        {
            int value = getValue(n, level);
            
            switch (level)
            {
                case Level.Level2:
                    return value - 15;
                case Level.Level3:
                    return value - 30;
            }

            return InvalidValue;
        }
    }
}