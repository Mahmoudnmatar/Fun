using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameContainer<T>
{
    private T value;

    public void SetItem(T item)
    {
        value = item;
    }

    public T GetItem()
    {
        return value;
    }
}



