namespace DifficultyTuningMod
{
    public abstract class DifficultyParameter
	{
		private float[] customValues;
		
		public DifficultyParameter()
		{
			initializeCustomValues();
		}
		
		protected abstract void initializeCustomValues();
		
		public string[] CustomValues
		{
			get
			{
				int count = customValues.Length;
				string[] result = new string[count];
				
				for (int i = 0; i < count; i++)
				{
					result[i] = customValues[i].ToString();
				}
				
				return result;
			}
		}
	}