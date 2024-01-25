using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] public int maxHealth = 0;
    public int health => enemy.health;

    Enemy enemy;
    

    private void Start()
    {
        enemy = new TestEnemy(maxHealth);
    }

    public void GetDamage(object sender, int damage)
    {
        enemy.GetDamage(sender, damage);
    }

    public int GetHealth() => health;

    public bool IsKilled()
    {
        if (enemy.IsDied())
        {
            Destroy(gameObject);
            return true;
        }
        return false;
    }
}
