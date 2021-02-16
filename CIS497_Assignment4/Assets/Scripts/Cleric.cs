using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleric : ClassDecorator
{
    public Unit unit;

    public override int Attack()
    {
        return (unit.Attack() - 3) * 3;
    }

    public override string GetDescription()
    {
        return unit.GetDescription() + " Cleric";
    }
}
