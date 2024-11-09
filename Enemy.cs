using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    // Constructor
    public Enemy(string name, int health) : base(name, health) { }

    // Attack method to reduce the health of another character
    public void Attack(Character target, int damage)
    {
        target.Health -= damage;
        Debug.Log(Name +" attacked "+ target.Name +" for " +damage + "." + target.Name + "'s New Health: " + target.Health);
    }
}

