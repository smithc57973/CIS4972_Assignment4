using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Unit
{
    public Unit unit;

    public override int Attack()
    {
        return unit.Attack() * 2;
    }

    public override string GetDescription()
    {
        return unit.GetDescription() + " Wizard";
    }
}
