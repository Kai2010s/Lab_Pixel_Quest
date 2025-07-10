using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Geocontroller : MonoBehaviour
{
    string Bye = "How are you?";
    int number1 = 1;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    public int speed = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        string goat = "somewhere";
        Debug.Log("Hello world");
        Debug.Log(Bye + goat);
        int num2 = 2;
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");
    }

}
      
    