/*
 * Chris Smith
 * Beholder
 * Assignment 4
 * A class for Beholder type enemies.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beholder : Enemy
{
    public override int Attack()
    {
        return damage;
    }

    // Start is called before the first frame update
    void Start()
    {
        health = 80;
        damage = 20;
        vulnerability = "Slashing";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
