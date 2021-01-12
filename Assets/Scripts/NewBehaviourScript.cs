using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update


    public Rigidbody2D rigidbody;

    Vector2 movement;

    [SerializeField]
    private score _score; 

    private void Start() 
    {
        _score = GetComponent<score>();
        if(_score != null)
        {
            Debug.Log("score script is found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //input
        if (Input.GetKeyDown(KeyCode.D))
            rigidbody.MovePosition(rigidbody.position + Vector2.right);
        else if (Input.GetKeyDown(KeyCode.A))
            rigidbody.MovePosition(rigidbody.position + Vector2.left);
        else if (Input.GetKeyDown(KeyCode.W))
            rigidbody.MovePosition(rigidbody.position + Vector2.up);
        else if (Input.GetKeyDown(KeyCode.S))
            rigidbody.MovePosition(rigidbody.position + Vector2.down);
        
    } 
    void OnTriggerEnter2D (Collider2D collider)
    {
        if (collider.tag == "enemy")
        {
            Debug.Log("WE LOST!");
            //score.currentscore = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            _score.IncreaseScore();
        }
            
        if (Input.GetKeyDown(KeyCode.S))
        {
            _score.DecreaseScore();
        }
            
    }
}

