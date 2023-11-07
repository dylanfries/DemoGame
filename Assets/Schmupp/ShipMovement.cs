using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public Vector2 input;

    public Rigidbody2D rb;

    public float force = 1f;

    public void FixedUpdate() {
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Debug.DrawRay(transform.position, input);

        rb.AddForce(input * force);
    }
}
