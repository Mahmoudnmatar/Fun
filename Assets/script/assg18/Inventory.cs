using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    
    private  List<string> ItemNames = new List<string>();


    public void  AddItem(string item){

        ItemNames.Add(item) ;
    }

    public void ShowItems(){

        foreach(string item in ItemNames){

        Debug.Log( item);
        }
    }

    public static Inventory operator + (Inventory a , Inventory b) {
         
         Inventory inventory = new Inventory(); 

        // her we cant add string to inventory so i used google 

        foreach(var item  in a.ItemNames) {

            inventory.AddItem(item);
        }
          foreach(var item  in b.ItemNames) {

            inventory.AddItem(item);
        }

         return inventory;
    }
   
}
