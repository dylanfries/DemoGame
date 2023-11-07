using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera2D : MonoBehaviour
{
    public Transform targetToFollow;
    public Vector3 targetOffset = new Vector3(0, 3f, 0);
    public float zOffset = -10f;
    public float moveSpeed = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Following the player

        Vector3 directionToPlayer = (targetToFollow.position)- transform.position;
        Debug.DrawRay(transform.position, directionToPlayer);

        Vector2 addFollowOffset = (Vector2)(directionToPlayer + targetOffset);
        Debug.DrawRay(targetToFollow.position, addFollowOffset, Color.cyan);

        //    directionToPlayer.z = zOffset; // not needed since we are dropping the Z when casting the V3 to V2

        // Apply the movement
        Vector2 movementStep = directionToPlayer.normalized * moveSpeed ;
        Debug.DrawRay(transform.position, movementStep, Color.blue);

        transform.Translate(movementStep * Time.deltaTime);
        Debug.DrawRay(transform.position, movementStep * Time.deltaTime, Color.red);
    }
}
