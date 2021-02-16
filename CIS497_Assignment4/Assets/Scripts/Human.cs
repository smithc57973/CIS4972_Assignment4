using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Unit
{
    public Human()
    {
        this.description = "Human";
        baseDmg = 5;
        numHits = 2;
    }

    public override int Attack()
    {
        Debug.Log(description + " deals 2 damage, 5 times");
        return baseDmg * numHits;
    }

}
