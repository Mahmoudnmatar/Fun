using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Assignment18
{
    public class CharacterTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Soldier soldier = new Soldier("Matar", 95, new Position(0, 0, 90));

            Officer officer = new Officer("Mego", 80, new Position(0, 0, 180));


            Character[] characters = { soldier, officer };


            for (int i = 0; i >= characters.Length; i++)
            {
                soldier.DisplayInfo();
                officer.DisplayInfo();
            }

            Debug.Log("Matar  health : " + soldier.Health);

            officer.Attack(30, soldier, " shooting ");

            Debug.Log("Matar  health after the war : " + soldier.Health);


        }

    }
}
