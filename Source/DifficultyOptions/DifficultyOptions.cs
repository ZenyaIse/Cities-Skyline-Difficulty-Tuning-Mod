namespace DifficultyTuningMod
{
    public class DifficultyOptions : Singleton<DifficultyOptions>
    {
		private Difficulties _difficulty = Difficulties.Normal;
		
		public Difficulties Difficulty
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