using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX4 : MonoBehaviour
{
    private void Start()
    {
        Movement();
    }

    private void Movement() //the function allows to the object make the ordered movement
    {
        transform.Translate(translation: Vector3.right);
    }
}
