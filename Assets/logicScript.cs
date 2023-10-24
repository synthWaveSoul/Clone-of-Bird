using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    // add context menu in unity to run method manually
    [ContextMenu("Increase Score")]
    public void addScore(){
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }

    public void resetGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
    }
}
