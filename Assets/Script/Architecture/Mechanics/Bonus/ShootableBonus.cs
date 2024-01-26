public abstract class Bonus
{
    public abstract int health { get; set; }
    public abstract int maxHealth { get; set; }

    public abstract void GetDamage(object sender, int damage);
    public abstract bool IsDied();
}

