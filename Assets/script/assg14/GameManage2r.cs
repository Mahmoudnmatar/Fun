using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{

    Player subhi = new Player("subhi ", 75);

    Enemy jewish = new Enemy("ntin", 100);

    void Start()
    {

        Debug.Log("Player Name  :  " + subhi.Name + " heal : " + subhi.Health);

        Debug.Log("Enemy Name  :  " + jewish.Name + " heal : " + jewish.Health);

        subhi.Heal(15);

        Debug.Log("player health = " + subhi.Health);

        jewish.Attack(subhi , 20);

        Debug.Log("player health = " + subhi.Health);

    }

}
