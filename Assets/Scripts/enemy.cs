using UnityEngine;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rigidbody;
    public float minSpeed = 4f;
    public float maxSpeed = 12f;
    float speed = 1f;
    void Start ()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //create a new vector to be identified so object can move foward
        Vector2 forward = new Vector2 (transform.right.x, transform.right.y);
        rigidbody.MovePosition (rigidbody.position + forward * Time.fixedDeltaTime * speed);

        if(transform.position.x < -14f || transform.position.x > 14)
        {
            Destroy(this.gameObject);
        }
    }
}
