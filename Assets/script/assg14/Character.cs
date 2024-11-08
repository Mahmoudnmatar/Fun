using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public static string name;

    public static int health;

    public Character(string name, int health)
    {

        Name = name;
        Health = health;


    }

    public string Name
    {
        get;
        set;
    }

    public int Health
    {

        // we can use this but we need to check the health < = 100
        get ; 
        set ; 

        // we can contorl the health by using if state  and check the value <=100  set the health = 100 ..... 


    }


}
