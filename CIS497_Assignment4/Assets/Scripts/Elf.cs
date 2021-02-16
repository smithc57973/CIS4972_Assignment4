using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : Unit
{
    public Elf()
    {
        this.description = "Elf";
        baseDmg = 5;
        numHits = 2;
    }

    public override int Attack()
    {
        Debug.Log(description + " deals 5 damage, 2 times");
        return baseDmg * numHits;
    }

}
