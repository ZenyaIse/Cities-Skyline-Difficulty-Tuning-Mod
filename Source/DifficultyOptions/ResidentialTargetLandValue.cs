using System;
using ICities;
using ColossalFramework;

namespace DifficultyTuningMod.DifficultyOptions
{
    public abstract class ResidentialTargetLandValue : DifficultyParameterMultiple
    {
        public ResidentialTargetLandValue() : base() { }
        
        protected override void InitValues()
        {
            nMin = -4;
            nMax = 10;
        }
        
        public override int GetValue(Level level)
        {
            DifficultyManager d = Singleton<DifficultyManager>.instance;
            
            int n = (d.Difficulty == Difficulties.Custom) ? nCustom : (int)d.Difficulty;
            
            return getValue(n, level);
        }
        
        protected override int getValue(int n, Level level)
        {
            switch (level)
            {
                case Level.Level2:
                    return -2 + 4 * n;
                case Level.Level3:
                    return 7 + 7 * n;
                case Level.Level4:
                    return 21 + 10 * n;
                case Level.Level5:
                    return 37 + 12 * n;
            }
            
            return InvalidValue;
        }
    }
}