/*
 * Chris Smith
 * Wizard
 * Assignment 4
 * A class for Wizard type Decorators.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Unit
{
    public Unit unit;

    public Wizard(Unit u)
    {
        this.unit = u;
        this.hp += 1;
    }

    public override int Attack()
    {
        return unit.Attack() * 2;
    }

    public override string GetDescription()
    {
        return unit.GetDescription() + " Wizard";
    }

    public override string GetDmgType()
    {
        return unit.GetDmgType();
    }

    public override int GetHP()
    {
        return unit.GetHP() + 1;
    }

    public override int GetLevel()
    {
        return unit.GetLevel() + 1;
    }
}
