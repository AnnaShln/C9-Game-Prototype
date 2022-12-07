using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool isGrounded;
    private string GROUND_TAG = "Ground";
    [SerializeField]
    private float speed = 5;
    [SerializeField]
    private float jumpHeight = 8.0f;
    //private float gravityValue = -9.81f;
    
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        
    }

    void Update()
    {
        PlayerMovement();
        PlayerJump();
    }

    private void FixedUpdate()
    {
        
    }

    //moving forward and backward
    void PlayerMovement()
    {
        float h = Input.GetAxisRaw("Horizontal");
        Vector3 pos = transform.position;
        pos.x += h * Time.deltaTime * speed;
        transform.position = pos;
    }

    //jumping
    void PlayerJump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
            rb.AddForce(new Vector3(0f, jumpHeight, 0f), ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(GROUND_TAG))
        {
            isGrounded = true;            
        }
    }
}
