using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{

    public int YearOfBirth = 2003;
    public int CurrentYear = 2022;

    public int age;

    private void Start()
    {
        //if we do the operation
        age = 2022 - 2003;
        //We must have

        Debug.Log($"If we are in the year {CurrentYear}, and you were born in the year {YearOfBirth}, you are {age} years old");
    }

}
