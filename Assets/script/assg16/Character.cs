using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment18
{
    public class Character
    {

        public string name;
        private int health;

        protected Position position;


        public int Health
        {

            get => health;
            set => health = Mathf.Clamp(health, 0, 100);
        }

        public Character(string name, int health, Position position)
        {

            this.name = name;

            // here we call the function we make it 
            this.health = health;
            this.position = position;

        }

        public Character() : this("No name", 100, new Position(0, 0, 0)) { }



        public virtual void DisplayInfo()
        {

            Debug.Log("Name : " + name + "Health : " + health);
            position.PrintPosition();
        }

        public void Attack(Character target, int damage)
        {

            target.health -= damage;

        }

        public void Attack(int damage, Character target, string attackType)
        {

            target.health -= damage;

            Debug.Log("attack type : " + attackType);


        }

    }
}
