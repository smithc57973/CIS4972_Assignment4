using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rogue : Unit
{
    public Unit unit;

    public override int Attack()
    {
        int sneak = Random.Range(0, 2);
        if (sneak == 0)
        {
            return unit.Attack() + 20;
        }
        else
        {
            return unit.Attack();
        }
        
    }

    public override string GetDescription()
    {
        return unit.GetDescription() + " Rogue";
    }
}
