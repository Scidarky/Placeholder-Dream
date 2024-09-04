using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plattie : MonoBehaviour
{
    public float fallingSecs;

    private TargetJoint2D target;
    private BoxCollider2D coll;
    void Start()
    {
        target = GetComponent<TargetJoint2D>();
        coll = GetComponent<BoxCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Invoke("Fall", fallingSecs);
        }
    }
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.layer == 8)
        {
            Destroy(gameObject);
        }
    }

    void Fall()
    {
        target.enabled = false;
        coll.isTrigger = true;
    }
}
