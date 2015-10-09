namespace DifficultyTuningMod
{
    public abstract class DifficultyParameterFloat
    {
        private float[] customValues;
        public float CustomValue;
        
        public abstract string Description { get; }
    }