using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera2D : MonoBehaviour
{
    public Transform targetToFollow;
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

        Vector3 directionToPlayer = (targetToFollow.position)  - transform.position;
    //    directionToPlayer.z = zOffset;
        Debug.DrawRay(transform.position, directionToPlayer);

        Vector2 movementStep = directionToPlayer.normalized * moveSpeed ;

        Debug.DrawRay(transform.position, movementStep, Color.blue);
        transform.Translate(movementStep * Time.deltaTime);
        Debug.DrawRay(transform.position, movementStep * Time.deltaTime, Color.red);
    }
}
