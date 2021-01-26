using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerOutScreen2 : MonoBehaviour
{
        void OnTriggerEnter2D(Collider2D other)
        {
        if (other.tag == "Player")
        {
            Debug.Log("WE LOST!");
            //score.currentscore = 0;
            SceneManager.LoadScene(4);
        }
    }
}
