using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver2 : MonoBehaviour
{
    
    public void RetryButton()
    {
        SceneManager.LoadScene(3);
    }
}
