/*
 * Chris Smith
 * Fighter
 * Assignment 4
 * A class for Fighter type Decorators.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : Unit
{
    public Unit unit;

    public Fighter(Unit u)
    {
        this.unit = u;
        this.hp += 10;
    }

    public override int Attack()
    {
        return unit.Attack() + 10;
    }

    public override string GetDescription()
    {
        return unit.GetDescription() + " Fighter";
    }

    public override string GetDmgType()
    {
        return unit.GetDmgType();
    }

    public override int GetHP()
    {
        return unit.GetHP() + 10;
    }

    public override int GetLevel()
    {
        return unit.GetLevel() + 1;
    }
}
