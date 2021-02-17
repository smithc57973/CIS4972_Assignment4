using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Unit
{
    public Human()
    {
        this.description = "Human";
        this.hp = 7;
        this.dmgType = "Slashing";
    }

    public override int Attack()
    {
        return 7 + (2 * level);
    }

}
