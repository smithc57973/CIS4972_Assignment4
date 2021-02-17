using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleric : ClassDecorator
{
    public Unit unit;

    public Cleric(Unit u)
    {
        this.unit = u;
        this.hp += 5;
    }

    public override int Attack()
    {
        return (unit.Attack() - 3) * 3;
    }

    public override string GetDescription()
    {
        return unit.GetDescription() + " Cleric";
    }

    public override string GetDmgType()
    {
        return unit.GetDmgType();
    }

    public override int GetHP()
    {
        return unit.GetHP() + 5;
    }

    public override int GetLevel()
    {
        return unit.GetLevel() + 1;
    }
}
