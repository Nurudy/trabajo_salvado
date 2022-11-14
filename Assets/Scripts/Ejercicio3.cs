using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    public int Age = 19;
    public string Name;

    private void Start()
    { //finally the message shows the player's age
        Debug.Log($"Hello, {Name}! You are {Age} years old");
    }
}
