using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBunny : MonoBehaviour
{
    public float speed = 10.0f;
    public float jumpForce = 1.0f;
    private Rigidbody2D rb;
    private float moveInput;

    public bool isGrounded;
    public bool isJumping;

    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;

    private float jumpTimeCounter;
    public float jumpTime;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        if(moveInput > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }else if(moveInput < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        if(isGrounded ==true && Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if(jumpTimeCounter > 0 && isJumping == true)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }

    }

    private void FixedUpdate()
    {
        rb.velocity = (new Vector2(moveInput * speed, rb.velocity.y));
    }
    void moveBunny(Vector2 direction)
    {
        rb.MovePosition(new Vector2(moveInput * speed, rb.velocity.y));
    }
    void onCollisionEnter()
    {
        isGrounded = true;
    }
    
}
