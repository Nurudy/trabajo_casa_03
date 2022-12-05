using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX10 : MonoBehaviour
{
    public int clickCounter; //it counts all your click and reacts to it

    private void AddOneToCounter()
    {
        clickCounter++;
        transform.localScale += Vector3.one;
    }

    private void Update() //complements the click counter
    {
        if (Input.GetMouseButtonDown(0))
        {
            AddOneToCounter();
        }
    }
}
