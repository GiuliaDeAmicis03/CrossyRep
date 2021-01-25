using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameOverScreen GameOverScreen;
    public Rigidbody2D rigidbody;
    public SpriteRenderer spriterenderer;

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
        //score.currentscore = 0; already a note stoopid
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            SceneManager.LoadScene(4);
        //if (collider.tag == "enemy")
        //{
        //    Debug.Log("WE LOST!");
        //    spriterenderer.enabled = false;
        }
    }
}
