using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player
{

    public string playerName ;
    public int health;

    public static int playerCount = 0;


    public void InitializePlayer(string name, int initialHealth)
    {

        playerName = name;

        health = initialHealth;

        playerCount++;
    }

    public void Heal(int amount)
    {

        health += amount;

        Debug.Log("health " + health);

    }

    public void Heal(bool fullRestor)
    {

        health = 100;

    }

    public static void ShowPlayerCount() {

        Debug.Log("player count " + playerCount);
    }

}
