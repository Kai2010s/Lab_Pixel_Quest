using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;


    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            spriteRenderer.color = Color.blue;

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            spriteRenderer.color = Color.yellow;

        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            spriteRenderer.color = Color.green;
        }
    }
}
