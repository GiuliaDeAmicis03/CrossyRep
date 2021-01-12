using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score1 : MonoBehaviour
{
    private int currentscore = 0;
    public Text scoreText;
    public Transform player;
    //initialiazation
    void Start ()
    {
        scoreText.text = currentscore.ToString();
        
    }
    void Update() 
    {
        scoreText.text = currentscore.ToString();
        scoreText.text = player.position.y.ToString();

    }
}
