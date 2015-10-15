using ICities;
using ColossalFramework;

namespace DifficultyTuningMod.DifficultyOptions
{
    public class IndustrialTargetScore : DifficultyParameterMultiple
    {
        public IndustrialTargetScore() : base() { }

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
                    return 20 + 5 * n;
                case Level.Level3:
                    return 40 + 10 * n;
            }

            return InvalidValue;
        }

        protected override int getTooLowValue(int n, Level level)
        {
            int value = getValue(n, level);
            
            switch (level)
            {
                case Level.Level2:
                    return value - 10;
                case Level.Level3:
                    return value - 20;
            }

            return InvalidValue;
        }
    }
}