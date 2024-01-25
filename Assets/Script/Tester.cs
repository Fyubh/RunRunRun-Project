using UnityEngine;
using System.Collections;
namespace RunRunRun.Architecture
{
    public class Tester : MonoBehaviour
    {
        public BankRepository repository;
        public BankInteractor interactor;

        private void Start()
        {
            this.repository = new BankRepository();
            this.repository.Initialize();

            this.interactor = new BankInteractor(repository);
            this.interactor.Initialize();
        }

        private void Update()
        {
            /* DEBUG
            if (Input.GetKeyDown(KeyCode.A))
            {
                this.interactor.AddCoins(this, 5);
                Debug.Log($"Bank balance added, current = {this.repository.coins}");
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                this.interactor.SpendCoin(this, 2);
                Debug.Log($"Bank balance spent, current = {this.repository.coins}");
            }
            */
        }
    }

}

