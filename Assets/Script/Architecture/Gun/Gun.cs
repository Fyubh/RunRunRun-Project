using UnityEngine;

public abstract class Gun
{
    public abstract float bulletSpeed { get; set; }
    public abstract int timer { get; set; }
    public abstract int damage { get; set; }

    // public virtual void IncreaseBulletSpeed(object sender, );
}
