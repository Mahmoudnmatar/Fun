using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public Enemy(string name, int health) :base ( name , health) 
    {
    }



    // in this function the target is the player or the rock or any think can be destroid 
    // if we remove the target the function well not work 
    public void Attack(Character target ,int amount)
    {

        target.Health -= amount ;

        // Health -= amount;
    }
}
