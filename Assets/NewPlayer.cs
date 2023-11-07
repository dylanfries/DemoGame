using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 input;
    public bool jump;
    
    // Settings
    public float moveSpeed = 1f;
    public float jumpForce = 1f;

    public Rigidbody2D rigid;

    // Update is called once per frame
    void Update()
    {
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        jump = Input.GetButton("Jump");

        Debug.DrawRay(transform.position, input);
    }

    private void FixedUpdate() {
        rigid.AddForce(input * moveSpeed);

        

        if (jump) {
            rigid.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            jump = false;
        }
    }
}
