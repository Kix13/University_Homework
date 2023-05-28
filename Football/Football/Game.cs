using System.Collections.Generic;

namespace Football
{
    internal class Game
    {
        private Team TeamOne;
        private Team TeamTwo;
        private Referee referee;
        private List<Referee> AssistantReferee;
        private Goal goals;
        private GameResult gameResult;
        private Team winner;

        public Game(Team teamOne, Team teamTwo, Referee referee, List<Referee> assistantReferee, Goal goals, GameResult gameResult, Team winner)
        {
            this.TeamOne = teamOne;
            this.TeamTwo = teamTwo;
            this.referee = referee;
            this.AssistantReferee = assistantReferee;
            this.goals = goals;
            this.gameResult = gameResult;
            this.winner = winner;
        }

        public Team GetTeamOne()
        {
            return TeamOne;
        }

        public void SetTeamOne(Team teamOne)
        {
            this.TeamOne = teamOne;
        }

        public Team GetTeamTwo()
        {
            return TeamTwo;
        }

        public void SetTeamTwo(Team teamTwo)
        {
            this.TeamTwo = teamTwo;
        }

        public Referee GetReferee()
        {
            return referee;
        }

        public void SetReferee(Referee referee)
        {
            this.referee = referee;
        }

        public List<Referee> GetAssistantReferee()
        {
            return AssistantReferee;
        }

        public void SetAssistantReferee(List<Referee> assistantReferee)
        {
            this.AssistantReferee = assistantReferee;
        }

        public Goal GetGoals()
        {
            return goals;
        }

        public void SetGoals(Goal goals)
        {
            this.goals = goals;
        }

        public GameResult GetGameResult()
        {
            return gameResult;
        }

        public void SetGameResult(GameResult gameResult)
        {
            this.gameResult = gameResult;
        }

        public Team GetWinner()
        {
            return winner;
        }

        public void SetWinner(Team winner)
        {
            this.winner = winner;
        }

        public override string ToString()
        {
            return "Game{" +
                "TeamOne=" + TeamOne +
                ", TeamTwo=" + TeamTwo +
                ", referee=" + referee +
                ", AssistantReferee=" + AssistantReferee +
                ", goals=" + goals +
                ", gameResult=" + gameResult +
                ", winner=" + winner +
                '}';
        }

        public class Goal
        {
            public double Minute { get; set; }
            public FootballPlayer Player { get; set; }

            public Goal(double minute, FootballPlayer player)
            {
                Minute = minute;
                Player = player;
            }

            public override string ToString()
            {
                return "Goal{" +
                    "minute=" + Minute +
                    ", player=" + Player +
                    '}';
            }
        }

        public class GameResult
        {
            public int TeamOneScore { get; set; }
            public int TeamTwoScore { get; set; }

            public GameResult(int teamOneScore, int teamTwoScore)
            {
                TeamOneScore = teamOneScore;
                TeamTwoScore = teamTwoScore;
            }

            public override string ToString()
            {
                return "GameResult{" +
                    "teamOneScore=" + TeamOneScore +
                    ", teamTwoScore=" + TeamTwoScore +
                    '}';
            }
        }
    }
}
    