using System;
using ColossalFramework;

namespace DifficultyTuningMod.DifficultyOptions
{
    public abstract class DifficultyParameterBase : IDifficultyParameter
    {
        protected int[] customValues;
        public int CustomValue;

        protected DifficultyParameterBase()
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
                return Array.IndexOf(customValues, Value);
            }

            set
            {
                if (value >= 0 && value < customValues.Length)
                {
                    CustomValue = customValues[value];
                }
            }
        }

        public int MaxIndex
        {
            get
            {
                return customValues.Length - 1;
            }
        }

        protected abstract string valueToStr(int value);

        public string GetValueStr(int index)
        {
            return valueToStr(customValues[index]);
        }
    }
}