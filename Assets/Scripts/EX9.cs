using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX9 : MonoBehaviour
{
    public int Base;
    public int Height;

    private void area(float num1, float num2)
    {
        if (num1 > 0 && num2 > 0) //the number has to be only in positive numbers
        {
            Debug.Log($"The area of the triangle is {(num1 + num2) / 2}");
        }
        else
        {
            Debug.Log($"The area of the triangle can not be calculated because the base or the height are negative ot 0");
        }

    }

    private void Start()
    {

        area(Base, Height);
    }
}
