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

        protected Difficulties getDifficultyFromValue(int value)
        {
            for (Difficulties d = Difficulties.Free; d <= Difficulties.Impossible; d++)
            {
                if (GetValue(d) == value) return d;
            }

            return Difficulties.Undefined;
        }

        public int Value
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

        //public string[] CustomValuesStr
        //{
        //    get
        //    {
        //        List<string> sl = new List<string>();

        //        for (int i = 0; i < customValues.Length; i++)
        //        {
        //            Difficulties d = getDifficultyFromValue(customValues[i]);
        //            sl.Add(valueToStr(customValues[i]) + getDifficultyNamePostfix(d));
        //        }

        //        return sl.ToArray();
        //    }
        //}

        //private string getDifficultyNamePostfix(Difficulties d)
        //{
        //    if (d == Difficulties.Undefined) return "";

        //    return " - " + DTMLang.Text(d.ToString());
        //}
    }
}