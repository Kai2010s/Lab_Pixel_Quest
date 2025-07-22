using System.Collections;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float CapsuleHeight = 0.25f;
    public float CapsuleRadius = 0.08f;
    public LayerMask groundMask;
    public Transform feetCollider;
    private bool _groundCheck;
    private Rigidbody2D rb;
    public float jumpForce = 10;
    public float fallForce = 4;
    private Vector2 gravityForce;
    private bool _waterCheck;
    private string _waterTag = "Water";


    // Start is called before the first frame update
    void Start()
    {
        gravityForce = new Vector2(0, Physics2D.gravity.y);
        rb = GetComponent<Rigidbody2D>();
    }
    void OnTriggerEnter(Collider other)
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        _groundCheck = Physics2D.OverlapCapsule(feetCollider.position,
        new Vector2(CapsuleHeight, CapsuleRadius), CapsuleDirection2D.Horizontal,
        0, groundMask);
        if (Input.GetKeyDown(KeyCode.Space) && _groundCheck)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce);
        }


        if (rb.velocity.y < 0)
        {
            rb.velocity += gravityForce * fallForce * Time.deltaTime;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(_waterTag)) { _waterCheck = true; }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(_waterTag)) { _waterCheck = false; }
    }
}

    