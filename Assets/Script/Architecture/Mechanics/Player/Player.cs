public abstract class Player
{
    public abstract bool isDied { get; set; }
    public abstract int moveSpeed { get; set; }
    public abstract int countPlayers { get; set; }

    public void KillPlayer()
    {
        isDied = true;
    }
}

