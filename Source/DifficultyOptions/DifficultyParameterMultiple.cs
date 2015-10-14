using System.Text;
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

        public int GetValue(Level level)
        {
            DifficultyManager d = Singleton<DifficultyManager>.instance;

            int n = (d.Difficulty == Difficulties.Custom) ? nCustom : (int)d.Difficulty;

            return getValue(n, level);
        }

        public int GetTooLowValue(Level level)
        {
            DifficultyManager d = Singleton<DifficultyManager>.instance;

            int n = (d.Difficulty == Difficulties.Custom) ? nCustom : (int)d.Difficulty;

            return getTooLowValue(n, level);
        }

        public int SelectedIndex
        {
            get
            {
                DifficultyManager d = Singleton<DifficultyManager>.instance;

                if (d.Difficulty == Difficulties.Custom)
                {
                    return nCustom - nMin;
                }
                else
                {
                    return (int)d.Difficulty - nMin;
                }
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
            
            for (Level level = Level.Level2; level <= Level.Level5; level++)
            {
                int value = getValue(n, level);
                if (value == InvalidValue) break;
                
                if (level != Level.Level2) sb.Append(", ");
                
                sb.Append(value < 0 ? 0 : value);
            }
            
            return sb.ToString();
        }
        
        protected abstract int getValue(int n, Level level);

        protected abstract int getTooLowValue(int n, Level level);
    }
}