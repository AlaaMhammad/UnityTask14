using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Create a Player and an Enemy
        Player1 player = new Player1("Subhi", 100);
        Enemy enemy = new Enemy("Zarifeh", 100);

        // Print their initial Name and Health
        Debug.Log(player.Name + " - Health: " + player.Health);
        Debug.Log(enemy.Name + " - Health: " + enemy.Health);

        // Test Heal method on player
        player.Heal(10);

        // Test Attack method on enemy to reduce player’s health
        enemy.Attack(player, 20);

    }

}
