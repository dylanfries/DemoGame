using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleCollider : MonoBehaviour
{
    public UnityEvent onCollision;

    public GameObject smoke;

    private void OnCollisionEnter2D(Collision2D collision) {

        if(collision.gameObject.tag != "Wall") {
            onCollision.Invoke();

            if(smoke != null) {
                // Create a smoke cloud at the position of the transform.
                // The last one is fun to say "Quat-ern-ian" and it is a 4 dimensional rotation
                // 
                Instantiate(smoke, transform.position, Quaternion.identity);
            }
            
        }


        
    }
}
