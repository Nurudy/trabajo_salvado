using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    public int number;

    private void Start()
    {
        if (number < 8)
        { //the condition that shows if it is "true"...
            Debug.Log($"The Number {number} belong to the weekend");
        }
        else
        {
            //..or false
            Debug.Log($"The number {number} does not belong to the weekend");
        }
    }
}


