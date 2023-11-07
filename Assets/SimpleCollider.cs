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

            Instantiate(smoke, transform.position, Quaternion.identity);
        }


        
    }
}
