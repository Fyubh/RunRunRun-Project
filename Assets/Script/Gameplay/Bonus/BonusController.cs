using UnityEngine;
using System.Collections;

public class BonusController : MonoBehaviour
{
    [SerializeField] public int maxHealth = 0;
    public int health => bonus.health;

    Bonus bonus;


    private void Start()
    {
        bonus = new TestShootableBonus(maxHealth);

        Destroy(gameObject, 20);
    }

    public void GetDamage(object sender, int damage)
    {
        bonus.GetDamage(sender, damage);
    }

    public int GetHealth() => health;

    public bool IsKilled()
    {
        if (bonus.IsDied())
        {
            Destroy(gameObject);
            return true;
        }
        return false;
    }
}

