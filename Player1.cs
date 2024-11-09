using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : Character
{
    // Constructor
    public Player1(string name, int health) : base(name, health) { }

    // Heal method to increase Health
    public void Heal(int amount)
    {
        Health += amount;
        Debug.Log(Name + " healed by " + amount + ". New Health: " + Health);
    }
}

