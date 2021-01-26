using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    
    public void RetryButton()
    {
        SceneManager.LoadScene(0);
    }
}
