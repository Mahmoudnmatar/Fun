using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInventory : MonoBehaviour
{
    void Start()
    {

        Inventory potion = new Inventory();

        potion.AddItem("Healing Potion") ;
        potion.AddItem("Strength Potion") ;

        Inventory elixirs = new Inventory() ;


        elixirs.AddItem("Elixirs");

        elixirs.AddItem("Dark Elixirs") ;

        Inventory inventory = potion + elixirs ;

        inventory.ShowItems();
        
    }


}
