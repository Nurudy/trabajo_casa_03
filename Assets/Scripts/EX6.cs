using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX6 : MonoBehaviour
{
    public int x;
    public int y;

    private void Start() // the function will show wich number is larger
    {
        if (x < y)
        {
            Debug.Log($"{y} is larger");
        }else if (x > y)
        {
            Debug.Log($"{x} is larger");
        }
    }
}
