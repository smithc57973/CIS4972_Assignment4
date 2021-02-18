using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : Enemy
{
    public override int Attack()
    {
        return damage;
    }

    // Start is called before the first frame update
    void Start()
    {
        health = 20;
        damage = 5;
        vulnerability = "Bludgeoning";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
