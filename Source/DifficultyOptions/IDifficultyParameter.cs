namespace DifficultyTuningMod.DifficultyOptions
{
    public interface IDifficultyParameter
    {
        string GetValueStr(int index);

        int MaxIndex { get; }

        int SelectedIndex { get; set; }
    }
}
