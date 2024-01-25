namespace RunRunRun.Architecture
{
    public class PlayerStatsInteractor : Interactor
    {
        private PlayerStatsRepository repository;

        public int scoreRecord => this.repository.scoreRecord;
        public int timeRecord => this.repository.timeRecord;

        public PlayerStatsInteractor(PlayerStatsRepository repository)
        {
            this.repository = repository;
        }

        public void ChangeTimeRecord(object sender, int time)
        {
            if (time > 0)
            {
                this.repository.scoreRecord = time;
            }
        }

        public void ChangeScoreRecord(object sender, int score)
        {
            this.repository.scoreRecord = score;
        }
    }
}
