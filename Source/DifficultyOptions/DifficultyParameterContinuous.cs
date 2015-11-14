using System;
using ColossalFramework;

namespace DifficultyTuningMod.DifficultyOptions
{
    public abstract class DifficultyParameterContinuous : IDifficultyParameter
    {
        protected int minValue;
        protected int maxValue;
        protected int step;
        public int CustomValue;

        protected DifficultyParameterContinuous()
        {
            InitValues();
        }

        protected abstract void InitValues();

        public abstract int GetValue(Difficulties difficultyLevel);

        public int Value
        {
            get
            {
                return GetValue(Singleton<DifficultyManager>.instance.Difficulty);
            }
            set
            {
                CustomValue = value;
            }
        }

        public int SelectedIndex
        {
            get
            {
                return (Value - minValue) / step;
            }

            set
            {
                CustomValue = minValue + value * step;
            }
        }

        public int MaxIndex
        {
            get
            {
                return (maxValue - minValue) / step;
            }
        }

        protected abstract string valueToStr(int value);

        public string GetValueStr(int index)
        {
            return valueToStr(minValue + index * step);
        }
    }
}