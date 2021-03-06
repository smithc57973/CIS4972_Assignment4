﻿/*
 * Chris Smith
 * Rogue
 * Assignment 4
 * A class for Rogue type Decorators.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rogue : Unit
{
    public Unit unit;

    public Rogue(Unit u)
    {
        this.unit = u;
        this.hp += 3;
    }

    public override int Attack()
    {
        int sneak = Random.Range(0, 10);
        if (sneak == 0)
        {
            return unit.Attack() + 20;
        }
        else
        {
            return unit.Attack() + 5;
        }
        
    }

    public override string GetDescription()
    {
        return unit.GetDescription() + " Rogue";
    }

    public override string GetDmgType()
    {
        return unit.GetDmgType();
    }

    public override int GetHP()
    {
        return unit.GetHP() + 3;
    }

    public override int GetLevel()
    {
        return unit.GetLevel() + 1;
    }
}
