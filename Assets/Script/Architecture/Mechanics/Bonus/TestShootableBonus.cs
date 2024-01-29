public class TestShootableBonus : Bonus
{
    public override int health { get; set; }
    public override int maxHealth { get; set; }

    public int increaseDamage { get; set; }

    public TestShootableBonus(int bonusHealth)
    {
        this.health = bonusHealth;
    }

    public override void GetDamage(object sender, int damage)
    {
        if (!IsDied())
        {
            health -= damage;
        }
    }

    public override bool IsDied() => health <= 0;

    public void IncreaseDamge(object sender,  Gun gun)
    {
        gun.IncreaseDamage(this, 100);
    }
}
