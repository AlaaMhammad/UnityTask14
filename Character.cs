using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    private string name;
    private int health;

    // Property for Name with getter and setter
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Property for Health with getter and setter
    public int Health
    {
        get { return health; }
        set
        {
            // Ensuring Health does not exceed 100 and is not negative
            if (value > 100)
            {
                health = 100;
            }

            else if (value < 0)
            {
                health = 0;
            }
            else
            {
                health = value;
            }
        }
    }

    // Constructor
    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }
}

