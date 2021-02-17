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
        health = 50;
        damage = 25;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
