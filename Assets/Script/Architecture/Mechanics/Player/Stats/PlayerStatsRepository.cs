using UnityEngine;

namespace RunRunRun.Architecture
{
    public class PlayerStatsRepository : Repository
    {
        private const string KEY_SCORE_RECORD = "PLAYERSTATS_SCORERECORD_KEY";
        private const string KEY_TIME_RECORD = "PLAYERSTATS_TIMERECORD_KEY";

        public int scoreRecord { get; set; }
        public int timeRecord { get; set; }
        public override void Initialize()
        {
            this.scoreRecord = PlayerPrefs.GetInt(KEY_SCORE_RECORD, 0);
            this.timeRecord = PlayerPrefs.GetInt(KEY_TIME_RECORD, 0);
        }

        public override void Save()
        {
            PlayerPrefs.SetInt(KEY_SCORE_RECORD, this.scoreRecord);
            PlayerPrefs.SetInt(KEY_TIME_RECORD, this.timeRecord);
        }
    }
}
