public class TestPlayer : Player
{
    public override bool isDied { get; set; }
    public override int countPlayers { get; set; }
    public override int moveSpeed { get; set; }
    // public 

    public TestPlayer(int countPlayers)
    {
        this.countPlayers = countPlayers;
    }
}

