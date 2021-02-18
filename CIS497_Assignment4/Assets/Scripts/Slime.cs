/*
 * Chris Smith
 * Slime
 * Assignment 4
 * A class for Slime type enemies.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Enemy
{
    public override int Attack()
    {
        return damage;
    }

    // Start is called before the first frame update
    void Start()
    {
        health = 40;
        damage = 10;
        vulnerability = "Piercing";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
