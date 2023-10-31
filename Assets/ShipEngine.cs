using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipEngine : MonoBehaviour
{

    public Vector2 input;
    public bool buttonDown;

    public float forceThrustAmount = 1f;
    public float torqueAmount = 1f;

    // Lets use physics
    public Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        buttonDown = Input.GetButton("Jump");
        // if button

        if (buttonDown) {
            //   transform.Translate(Vector3.forward);
            rigid.AddForce(transform.forward * forceThrustAmount); // use local forward
        }

        //transform.Rotate(new Vector3(input.y, input.x, 0));
        rigid.AddRelativeTorque(new Vector3(input.y, input.x, 0) * torqueAmount);

    }
}
