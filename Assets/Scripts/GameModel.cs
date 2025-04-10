namespace DefaultNamespace
{
    public class GameModel
    {
        public int Score { get; private set; }
        public int HighScore { get; private set; }

        public GameModel()
        {
        }

        public void IncreaseScore()
        {
            Score++;
            if (Score > HighScore)
            {
                HighScore = Score;
            }
        }
    }
}