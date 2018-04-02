namespace Practice20180402_v1
{
    public class TennisGame
    {
        private int _firstPlayerScoreTimes;

        public string Score()
        {
            if (_firstPlayerScoreTimes == 1)
            {
                return "Fifteen Love";
            }
            else if (_firstPlayerScoreTimes == 2)
            {
                return "Forty Love";
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }
    }
}