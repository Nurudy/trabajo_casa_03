using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX7 : MonoBehaviour
{
    public float num;

    private void real(float absolute) //the functions show the parameters
    {
        if(absolute > 0)
        {
            Debug.Log($"{absolute * 1}");
        }else if(absolute < 0)
        {
            Debug.Log($"{absolute * -1}");
        }
    }

    private void Start() //it returns the absolute value
    {
        real(num);
    }
}
