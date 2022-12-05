using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX8 : MonoBehaviour
{
    public int year;

    private void Start()
    {
        LeapYear(year);
    }

    private void LeapYear(int Num)
    {
        if (year % 4 == 0 || year % 100 > 0 || year % 400 == 0)
        {
            Debug.Log($"The year {Num} it's a leap year");
        }
        else
        {
            Debug.Log($"The year {Num} it is not a leap year");
        }
    }
}
