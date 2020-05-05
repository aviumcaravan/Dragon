public abstract class Character
{
    public abstract float GetXAxis(); //Player.cs:13, Dragon.cs:13
    public abstract float GetYAxis(); //Player.cs:18, Dragon.cs:18

    public abstract void SetPos(float x, float y); //Player.cs:24, Dragon.cs:24

    public abstract float GetDistanceToTarget(Character protag, Character target); //Player.cs:32, Dragon.cs:32
    public abstract float FindNearestTarget(Character player, Character[] characters); //Player.cs:41, Dragon.cs:41
}