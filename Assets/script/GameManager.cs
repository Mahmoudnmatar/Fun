using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        player m1 = new player(); 

        player m2 = new player() ; 

        m1.InitializePlayer("matar" , 100);

        m2.InitializePlayer("mego" , 80) ; 


        m1.Heal(50);

        m2.Heal(true) ;


        player.ShowPlayerCount(); 

    }



}
