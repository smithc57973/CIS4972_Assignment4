/*
 * Chris Smith
 * Enemy
 * Assignment 4
 * An abstract class defining basic enemy functions.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public int health;
    public int damage;
    public string vulnerability;

    public abstract int Attack();
}
