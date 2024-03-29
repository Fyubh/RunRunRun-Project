﻿using UnityEngine;

public abstract class Gun
{
    public abstract float bulletSpeed { get; set; }
    public abstract int timer { get; set; }
    public abstract int damage { get; set; }

    public virtual void IncreaseBulletSpeed(object sender, int value)
    {
        this.bulletSpeed += value;
    }
    public virtual void IncreaseTimer(object sender, int value)
    {
        this.timer += value;
    }
    public virtual void IncreaseDamage(object sender, int value)
    {
        this.damage += damage;
    }
}
