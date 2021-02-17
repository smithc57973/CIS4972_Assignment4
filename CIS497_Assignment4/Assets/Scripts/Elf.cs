using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : Unit
{
    public Elf()
    {
        this.description = "Elf";
        this.hp = 10;
        this.dmgType = "Piercing";
    }

    public override int Attack()
    {
        return 4 * level;
    }

}
