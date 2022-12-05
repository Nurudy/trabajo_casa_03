using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX1 : MonoBehaviour
{
    public string vowel;

    private void Start()
    {
        letter();
    }

    private bool letter() //it contains all the vocals to say
    {
        if (vowel == "a" || vowel == "e" || vowel == "i" || vowel == "o" || vowel == "u")
            {
                Debug.Log("Es una vocal");
            return true;

            }
            else
            {
                Debug.Log("No es una vocal"); // When the letter is not a vocal it returns to false
            return false;
            }
    }
}
