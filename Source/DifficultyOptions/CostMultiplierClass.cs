namespace DifficultyTuningMod
{
    public class CostMultiplierClass
    {
        private float[] customValues;
        public float CustomValue;
		
		public CostMultiplierClass()
		{
            CustomValue = 1f;
            customValues = new float[] { 0, 0.2f, 0.5f, 1, 1.1f, 1.25f, 1.5f, 2, 3, 5, 10, 20 };
		}
        
        public string Description
        {
            get
            {
                return DTMLang.Text("CONSTRUCTION_COST");
            }
        }
        
        public float GetValue(Difficulties difficultyLevel)
        {
            switch (difficultyLevel)
            {
                case Difficulties.Easy:
                    return 0.5f;
                case Difficulties.Normal:
                    return 1;
                case Difficulties.Medium:
                    return 1.1f;
                case Difficulties.Hard:
                    return 1.25f;
                case Difficulties.Advanced:
                    return 1.5f;
                case Difficulties.Expert:
                    return 2;
                case Difficulties.Challenge:
                    return 3;
                case Difficulties.Impossible:
                    return 5;
                case Difficulties.Custom:
                    return CustomValue;
            }

            return 1f;
        }
		
		private Difficulties getDifficultyFromValue(float value)
		{
			for (Difficulties d = Difficulties.Easy; d <= Difficulties.Impossible; d++)
			{
				if (GetValue(d) == value) return d;
			}
			
			return Difficulties.None;
		}
        
        public float Value
        {
            get
            {
                return GetValue(Singleton<DifficultyOptions>.instance.Difficulty);
            }
            set
            {
                CustomValue = Value;
            }
        }
		
		public int SelectedOptionIndex
		{
			get
			{
				return Array.IndexOf(customValues, Value);
			}
			
			set
			{
				if (value >=0 && value < customValues.Count)
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

                for (int i = 0; i < customValues.Count; i++)
                {
					Difficulties d = getDifficultyFromValue(customValues[i]);
                    sl.Add(valueToStr(customValues[i]) + getDifficultyNamePostfix(d));
                }

                return sl.ToArray();
			}
		}
		
		private string valueToStr(float value)
		{
			return (value * 100).ToString() + "%";
		}
		
		private string getDifficultyNamePostfix(Difficulties d)
		{
			if (d == Difficulties.None) return "";
			
			return " - " + DTMLang.Text(d.ToString());
		}
    }
}