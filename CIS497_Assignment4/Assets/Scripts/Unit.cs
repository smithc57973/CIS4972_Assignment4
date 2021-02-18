/*
 * Chris Smith
 * Unit
 * Assignment 4
 * An abstract class to describe a base player unit.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit
{
    public string description;
    public string dmgType;
    public int level;
    public int maxLevel = 5;
    public int hp;

    public virtual string GetDescription()
    {
        return description;
    }

    public virtual string GetDmgType()
    {
        return dmgType;
    }

    public virtual int GetLevel()
    {
        return level;
    }

    public virtual int GetHP()
    {
        return hp;
    }

    public abstract int Attack();
}
