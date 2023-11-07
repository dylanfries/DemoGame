using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleCollider : MonoBehaviour
{
    public UnityEvent onCollision;

    private void OnCollisionEnter2D(Collision2D collision) {
        onCollision.Invoke();
    }
}
