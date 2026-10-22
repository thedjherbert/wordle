namespace Wordle;

public class Features {
    public int[] ScoreRows { get; set; } = new int[6];
    public double[] ScorePercentage { get; set; } = new double[6];
    public string HintMessage { get; set; } = "";
    public bool ShowHintPopUp { get; set; } = false;
}