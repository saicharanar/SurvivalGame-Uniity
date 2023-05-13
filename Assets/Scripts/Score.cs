public class Score
{
    private static float _currentScore;

    public static float currentScore
    {
        set => _currentScore = value;
        get => _currentScore;
    }

    private Score() {}
    
}
