using ICities;
using ColossalFramework;

namespace DifficultyTuningMod.DifficultyOptions
{
    public class OfficeTargetScore : DifficultyParameterMultiple
    {
        public OfficeTargetScore() : base() { }

        protected override void InitValues()
        {
            nMin = -7;
            nMax = 10;
        }

        protected override int getValue(int n, Level level)
        {
            switch (level)
            {
                case Level.Level2:
                    return 35 + 5 * n;
                case Level.Level3:
                    return 70 + 10 * n;
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