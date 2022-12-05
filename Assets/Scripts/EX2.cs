using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX2 : MonoBehaviour
{
    public int Number;

    void Start()
    {
        Number2(Number);
    }

    private bool Number2(int Num)
    {
        if (Num % 2 == 0) //we put the number 2 for a clear calculation
        {
            Debug.Log(message: $"{Num} is pair");
            return true;

        }
        else
        {
            Debug.Log(message: $"The {Number} is not pair"); //when the number can not be divided by two
            return false;
        }


    }
}
