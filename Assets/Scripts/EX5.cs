using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX5 : MonoBehaviour
{
    public int MultX = 2;

    private void Start()
    {
        Operation(MultX);
    }

    private void Operation(int Mult) //throw the inspector you would change the number and get the tablenum answer
    {
        Debug.Log($"{Mult} x 1 = {Mult * 1}");
        Debug.Log($"{Mult} x 2 = {Mult * 2}");
        Debug.Log($"{Mult} x 3 = {Mult * 3}");
        Debug.Log($"{Mult} x 4 = {Mult * 4}");
        Debug.Log($"{Mult} x 5 = {Mult * 5}");
        Debug.Log($"{Mult} x 6 = {Mult * 6}");
        Debug.Log($"{Mult} x 7 = {Mult * 7}");
        Debug.Log($"{Mult} x 8 = {Mult * 8}");
        Debug.Log($"{Mult} x 9 = {Mult * 9}");
        Debug.Log($"{Mult} x 10 = {Mult * 10}");


    }
}
