namespace DifficultyTuningMod
{
    public class DifficultyOptions
    {
		private Difficulties _difficulty = Difficulties.Normal;
		public DifficultyOptions Instance;
		
		public static Difficulties Difficulty
		{
			get
			{
				return Instance._difficulty;
			}
			
			set
			{
				Instance._difficulty = value;
			}
		}
	}
}