using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject followTarget;
    public Vector3 locationOfTarget;
    public Vector3 ourLocation;

    // 0 to 1
    public float lerpAmount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // --- This Handles Movement ---
        // Store our current location
        ourLocation = transform.position;
        // Stores the location of the target (as a Vector3)
        locationOfTarget = followTarget.transform.position;
        // Find an intermediariary point between the us and them. 
        // The Lerp Amount Variable controls how much each contributes to the final position. 
        Vector3 nextFramePosition = Vector3.Lerp(locationOfTarget, ourLocation, lerpAmount);
        // Set our position to the location we just created. 
        transform.position = nextFramePosition;
    
        // Update Rotation
        // Cheating a bit here. 
        transform.LookAt(locationOfTarget);
    
    }

    
}
