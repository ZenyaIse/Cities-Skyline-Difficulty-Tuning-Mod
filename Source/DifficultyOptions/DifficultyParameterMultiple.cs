using System;
using ICities;
using ColossalFramework;

namespace DifficultyTuningMod.DifficultyOptions
{
    public abstract class DifficultyParameterMultiple : IDifficultyParameter
    {
        protected const int InvalidValue = -9999;
        protected int nMin;
        protected int nMax;
        protected int nCustom;

        protected DifficultyParameterMultiple()
        {
            nCustom = (int)Difficulties.Normal;
            InitValues();
        }

        protected abstract void InitValues();
        
        public abstract int GetValue(Level level);
        
        public int SelectedIndex
        {
            get
            {
                return nCustom - nMin;
            }

            set
            {
                nCustom = value + nMin;
                if (nCustom < nMin) nCustom = nMin;
                if (nCustom > nMax) nCustom = nMax;
            }
        }

        public int MaxIndex
        {
            get
            {
                return nMax - nMin + 1;
            }
        }

        public string GetValueStr(int index)
        {
            int n = index + nMin;
            StringBuilder sb = new StringBuilder();
            
            for (Levels level = Levels.Level2; level <= Levels.Level5; level++)
            {
                int value = getValue(n, level);
                if (n == InvalidValue) break;
                
                if (level != Levels.Level1) sb.Append(",");
                
                sb.Append(value.ToSting());
            }
            
            return sb.ToString();
        }
        
        protected abstract int getValue(int n, Level level);
    }
}