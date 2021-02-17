using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dwarf : Unit
{
    public Dwarf()
    {
        this.description = "Dwarf";
        this.hp = 15;
        this.dmgType = "Bludgeoning";
    }

    public override int Attack()
    {
        return 12;
    }

}
