using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipEngine : MonoBehaviour
{

    public Vector2 input;
    public bool buttonDown;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        // if button
        transform.Translate(Vector3.forward);
        transform.Rotate(new Vector3(input.y, input.x, 0));

    }
}
