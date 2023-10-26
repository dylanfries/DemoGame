using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotator : MonoBehaviour
{

    public Vector3 rotationToAdd;

    // use local axis for now. 


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationToAdd * Time.deltaTime, Space.Self);
    }
}
