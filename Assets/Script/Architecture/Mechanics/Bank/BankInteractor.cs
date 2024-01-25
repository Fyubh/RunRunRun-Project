namespace RunRunRun.Architecture
{
    public class BankInteractor : Interactor
    {
        private BankRepository repository;

        public int coins => this.repository.coins;

        public BankInteractor(BankRepository repository)
        {
            this.repository = repository;
        }

        public bool IsEnoughtCoins(int value) => coins >= value;

        public void AddCoins(object sender, int value)
        {
            this.repository.coins += value;
            this.repository.Save();
        }

        public void SpendCoin(object sender, int value)
        {
            this.repository.coins -= value;
            this.repository.Save();
        }
    }
}
