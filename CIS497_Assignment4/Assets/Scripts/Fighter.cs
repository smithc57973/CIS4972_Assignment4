using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : Unit
{
    public Unit unit;

    public override int Attack()
    {
        return unit.Attack() + 10;
    }

    public override string GetDescription()
    {
        return unit.GetDescription() + " Fighter";
    }
}
