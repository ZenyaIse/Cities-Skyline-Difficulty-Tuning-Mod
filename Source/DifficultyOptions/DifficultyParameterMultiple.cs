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
        public int nCustom;

        protected DifficultyParameterMultiple()
        {
            nCustom = (int)Difficulties.Normal;
            InitValues();
        }

        protected abstract void InitValues();

        public int GetValue(Level level)
        {
            DifficultyManager d = Singleton<DifficultyManager>.instance;

            int n = get_n_fromDifficulty(d.Difficulty);

            return getValue(n, level);
        }

        public int GetTooLowValue(Level level)
        {
            DifficultyManager d = Singleton<DifficultyManager>.instance;

            int n = get_n_fromDifficulty(d.Difficulty);

            return getTooLowValue(n, level);
        }

        private int get_n_fromDifficulty(Difficulties difficulty)
        {
            switch (difficulty)
            {
                case Difficulties.Easy:
                case Difficulties.Normal:
                case Difficulties.Advanced:
                case Difficulties.Hard:
                case Difficulties.Expert:
                case Difficulties.Challenge:
                case Difficulties.Impossible:
                    return (int)difficulty;
                case Difficulties.Custom:
                    return nCustom;
                case Difficulties.Free:
                    return nMin;
                case Difficulties.FiveHundred:
                    return (int)Difficulties.Normal;
                case Difficulties.Demand111:
                    return (int)Difficulties.Normal;
                case Difficulties.HardAndFast:
                    return (int)Difficulties.Impossible;
                case Difficulties.PublicTransport:
                    return (int)Difficulties.Normal;
                case Difficulties.LowCity:
                    return nMax;
                default:
                    return (int)difficulty;
            }
        }

        public int SelectedIndex
        {
            get
            {
                DifficultyManager d = Singleton<DifficultyManager>.instance;

                return get_n_fromDifficulty(d.Difficulty) - nMin;
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
                return nMax - nMin;
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