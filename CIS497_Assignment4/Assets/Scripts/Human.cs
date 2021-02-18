/*
 * Chris Smith
 * Human
 * Assignment 4
 * A class for Human type Units.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Unit
{
    public Human()
    {
        this.description = "Human";
        this.hp = 10;
        this.dmgType = "Slashing";
    }

    public override int Attack()
    {
        return 10;
    }

}
