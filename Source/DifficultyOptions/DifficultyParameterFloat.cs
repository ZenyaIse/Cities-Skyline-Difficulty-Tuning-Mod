using System;
using System.Collections.Generic;
using ColossalFramework;

namespace DifficultyTuningMod.DifficultyOptions
{
    public abstract class DifficultyParameterFloat : IDifficultyParameter
    {
        protected float[] customValues;
        public float CustomValue;

        protected DifficultyParameterFloat()
        {
            InitValues();
        }

        protected abstract void InitValues();

        public abstract string Description { get; }

        public abstract float GetValue(Difficulties difficultyLevel);

        protected Difficulties getDifficultyFromValue(float value)
        {
            for (Difficulties d = Difficulties.Free; d <= Difficulties.Impossible; d++)
            {
                if (GetValue(d) == value) return d;
            }

            return Difficulties.Undefined;
        }

        public float Value
        {
            get
            {
                return GetValue(Singleton<DifficultyManager>.instance.Difficulty);
            }
            set
            {
                CustomValue = Value;
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

        public string[] CustomValuesStr
        {
            get
            {
                List<string> sl = new List<string>();

                for (int i = 0; i < customValues.Length; i++)
                {
                    Difficulties d = getDifficultyFromValue(customValues[i]);
                    sl.Add(valueToStr(customValues[i]) + getDifficultyNamePostfix(d));
                }

                return sl.ToArray();
            }
        }

        public int MaxIndex
        {
            get
            {
                return customValues.Length - 1;
            }
        }

        protected abstract string valueToStr(float value);

        private string getDifficultyNamePostfix(Difficulties d)
        {
            if (d == Difficulties.Undefined) return "";

            return " - " + DTMLang.Text(d.ToString());
        }

        public string GetValueStr(int index)
        {
            return valueToStr(customValues[index]);
        }
    }
}