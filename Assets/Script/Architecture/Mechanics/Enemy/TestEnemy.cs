public class TestEnemy : Enemy
{
    public override int health { get; set; }
    public override int maxHealth { get; set; }

    public TestEnemy(int enemyHealth)
    {
        this.health = enemyHealth;
    }

    public override void GetDamage(object sender, int damage)
    {
        this.health -= damage;
    }

    public override bool IsDied() => this.health <= 0;
}

