using System;
using System.Collections.Generic;

public class Dragon:Character
{
    private float x, y;
    public Dragon(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public override float GetXAxis()
    {
        //returns the x-axis position
        return this.x;
    }
    public override float GetYAxis()
    {
        //returns the y-axis position
        return this.y;
    }

    public override void SetPos(float x, float y)
    {
        //this method is a follow-up to the constructor
        //it imports the class local private variables and changes them to the method parameters
        this.x = x;
        this.y = y;
    }

    public override float GetDistanceToTarget(Character protag, Character target)
    {
        //this method calculates the distance between 2 objects
        float x = protag.GetXAxis() - target.GetXAxis();
        float y = protag.GetYAxis() - target.GetYAxis();
        float d = (float) Math.Sqrt((x * x) + (y * y));
        return d;
    }

    public override float FindNearestTarget(Character player, Character[] characters)
    {
        //this method is supposed to return the distance to the closest target
        float dist = float.MaxValue;

        for (int n = 0; n < characters.Length; n++)
        {
            if (characters[n] != null)
                if (characters[n].GetDistanceToTarget(player, characters[n]) < dist)
                    dist = characters[n].GetDistanceToTarget(player, characters[n]);
        }

        return dist;
    }
}