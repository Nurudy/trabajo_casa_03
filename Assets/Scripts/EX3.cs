using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX3 : MonoBehaviour
{
    public int divinded;
    public int divisor;

    private void Start()
    {
        Result(divinded % divisor);
    }

    private bool Result(int Num) //el "given" es la clave en el enunciado
    {
        if (divinded % divisor == 0) //we put both values
        {
            Debug.Log(message: $"The {Num} is exact");
            return true;
        }
        else
        {
            Debug.Log(message: $"The {Num} is not exact"); //is not exact when the result don't show a 0 result
            return false;
        }

    }

}
