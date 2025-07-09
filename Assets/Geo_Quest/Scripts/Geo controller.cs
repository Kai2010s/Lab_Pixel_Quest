using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geocontroller : MonoBehaviour
{
    string Bye = "How are you?";
    int number1 = 1;
    // Start is called before the first frame update
    void Start()

    {
        string goat = "somewhere";
        Debug.Log("Hello world");
        Debug.Log(Bye + goat);
        int num2 = 2;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(number1);
        number1++;
    }
}
