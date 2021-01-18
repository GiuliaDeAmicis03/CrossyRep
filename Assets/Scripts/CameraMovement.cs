using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Rigidbody2D rigidbody; 
    float speed = 0.4f; 

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 forward = new Vector2 (transform.up.x, transform.up.y);
        rigidbody.MovePosition (rigidbody.position + forward * Time.fixedDeltaTime * speed);
    }
}
