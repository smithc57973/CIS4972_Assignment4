using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit
{
    public string description;
    public int baseDmg;
    public int numHits;

    public virtual string GetDescription()
    {
        return description;
    }

    public abstract int Attack();
}
