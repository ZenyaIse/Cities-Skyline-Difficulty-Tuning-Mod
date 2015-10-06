namespace DifficultyTuningMod
{
    public class CostMultiplier : DifficultyParameter
	{
		public float CustomValue = 1f;
		private float[] customValues;
		
		protected override void initializeCustomValues()
		{
			customValues = new float[] { 0, 0.2, 0.5, 1, 1.1, 1.25, 1.5, 2, 3, 5, 10, 20 };
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
                    return 1f;
                case Difficulties.Medium:
                    return 1.1f;
                case Difficulties.Hard:
                    return 1.25f;
                case Difficulties.Advanced:
                    return 1.5f;
                case Difficulties.Expert:
                    return 2f;
                case Difficulties.Challenge:
                    return 3f;
                case Difficulties.Impossible:
                    return 5f;
                case Difficulties.Custom:
                    return CustomValue;
            }

            return 1f;
		}
	}
}