using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    public string name;
    public string City;

        private void Start()
    { //this message shows the city where player at
        Debug.Log($"¡Hello {name}, welcome to {City}");
    }

}
