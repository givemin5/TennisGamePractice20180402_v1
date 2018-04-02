﻿using System.Collections.Generic;

namespace Practice20180402_v1
{
    public class TennisGame
    {
        private int _firstPlayerScoreTimes;
        private int _secondPlayerScoreTimes;

        private Dictionary<int, string> scoreLookup = new Dictionary<int, string>
            {
                {0, "Love"},
                {1, "Fifteen"},
                {2, "Thirty"},
                {3, "Forty"},
            };

        public string Score()
        {
            if (_firstPlayerScoreTimes != _secondPlayerScoreTimes)
            {
                return scoreLookup[_firstPlayerScoreTimes] + " " + scoreLookup[_secondPlayerScoreTimes];
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScoreTimes++;
        }
    }
}