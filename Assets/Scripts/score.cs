using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    private int currentscore = 0;
    public Text scoreText;
    //initialiazation
    void Start ()
    {
        scoreText.text = currentscore.ToString();
        
    }
    void Update() 
    {
        scoreText.text = currentscore.ToString();
    }
    public void IncreaseScore()
    {
        currentscore++;
        Debug.Log("Increased: " + currentscore);
    }
    public void DecreaseScore()
    {
        currentscore--;
        Debug.Log("Decreased: " + currentscore);
    }

}
