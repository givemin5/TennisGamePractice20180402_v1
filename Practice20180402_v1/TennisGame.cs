namespace Practice20180402_v1
{
    public class TennisGame
    {
        private int _firstPlayerScoreTimes;

        public string Score()
        {
            if (_firstPlayerScoreTimes > 0)
                return "Fifteen Love";
            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }
    }
}