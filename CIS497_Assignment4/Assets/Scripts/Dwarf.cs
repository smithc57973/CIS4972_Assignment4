using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dwarf : Unit
{
    public Dwarf()
    {
        this.description = "Dwarf";
        baseDmg = 5;
        numHits = 2;
    }

    public override int Attack()
    {
        Debug.Log(description + " deals 10 damage");
        return baseDmg * numHits;
    }

}
