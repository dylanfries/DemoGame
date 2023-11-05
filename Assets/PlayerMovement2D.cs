using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    public Vector2 input;
    public bool jump = false;
    public bool jumpPressedThisFrame = false;

    public float xForce = 1f;
    public float jumpForce = 1f;


    public Rigidbody2D rigid;

    public Animator anim;
    public SpriteRenderer spriteRenderer;
    public bool facingLeft = false;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        jump = Input.GetButton("Jump");
        

        /// --- Animation stuff
        // Simple way for prototyping
        anim.SetBool("isJumping", jump);

        if (input.x < -.1f || input.x > 0.1f) {
            anim.SetBool("isRunning", true);
        } else {
            anim.SetBool("isRunning", false);
        }

        if (input.x < -.1f) {
            facingLeft = true;    
        } else {
            facingLeft = false;
        }

        spriteRenderer.flipX = facingLeft;

        if (input.y < -.1) {
            // Holding down button
            anim.SetBool("isDucking", true);
        } else {
            anim.SetBool("isDucking", false);
        }
    }

    private void FixedUpdate() {
        jumpPressedThisFrame = Input.GetButtonDown("Jump");

        rigid.AddForce(new Vector2( input.x * xForce, 0), ForceMode2D.Force);
        if (jumpPressedThisFrame) {
            rigid.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }
}
